using System;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;

namespace VleisurePartner.Logic.Transport
{
    public class EndPoint : IEndPoint
    {
        private const string JsonMediaType = "application/json";
        private readonly HttpClient _httpClient;
        private static string _userName = ConfigurationManager.AppSettings["vleisure:ApiUserName"];
        private static string _accessToken = ConfigurationManager.AppSettings["vleisure:ApiAccessToken"];

        public EndPoint(string endPointUri) : this(endPointUri, JsonMediaType)
        {
        }

        public EndPoint(string endPointUri, string defaultAcceptRequestHeaderMediaType)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri($"{endPointUri}/") };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(defaultAcceptRequestHeaderMediaType));
        }

        private async Task<HttpClient> GetHttpClient()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
            return await Task.FromResult(_httpClient);
        }

        public async Task<HttpRequestOperationResult<TResponse>> GetAsync<TResponse>(string path)
        {
            var httpClient = await GetHttpClient();
            var response = await httpClient.GetAsync(path);
            return await ProcessHttpResponseMessageAsync<TResponse>(response);
        }

        public async Task<HttpRequestOperationResult<TResponse>> GetAsync<TRequest, TResponse>(string path, TRequest requestDataObject)
        {
            return await GetAsync<TResponse>($"{path}?{ConvertToQueryString(requestDataObject)}");
        }

        public async Task<HttpRequestOperationResult<TResponse>> PutAsync<TRequest, TResponse>(string path, TRequest requestDataObject)
        {
            var httpClient = await GetHttpClient();
            var response = await httpClient.PutAsync(path, ConvertToJsonStringContent(requestDataObject));
            return await ProcessHttpResponseMessageAsync<TResponse>(response);
        }

        public async Task<HttpRequestOperationResult<TResponse>> PostAsync<TRequest, TResponse>(string path, TRequest requestDataObject)
        {
            var httpClient = await GetHttpClient();
            var response = await httpClient.PostAsync(path, ConvertToJsonStringContent(requestDataObject));
            return await ProcessHttpResponseMessageAsync<TResponse>(response);
        }

        [Obsolete("This is a stop gap for posting jQuery DataTables form data.")]
        public async Task<HttpRequestOperationResult<TResponse>> PostAsync<TResponse>(string path, HttpContent content)
        {
            var httpClient = await GetHttpClient();
            var response = await httpClient.PostAsync(path, content);
            return await ProcessHttpResponseMessageAsync<TResponse>(response);
        }

        private StringContent ConvertToJsonStringContent<TRequest>(TRequest content)
        {
            var jsonString = JsonConvert.SerializeObject(content);
            return new StringContent(jsonString, Encoding.UTF8, JsonMediaType);
        }

        private async Task<HttpRequestOperationResult<TResponse>> ProcessHttpResponseMessageAsync<TResponse>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                return new HttpRequestOperationResult<TResponse>(response.StatusCode);
            }

            using (var stream = await response.Content.ReadAsStreamAsync())
            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return new HttpRequestOperationResult<TResponse>(new JsonSerializer().Deserialize<TResponse>(jsonReader));
            }
        }

        private string ConvertToQueryString<TModel>(TModel request, string separator = ",")
        {
            if (request == null)
                throw new ArgumentNullException("request");

            // Get all properties on the object
            var properties = request.GetType().GetProperties()
                .Where(x => x.CanRead)
                .Where(x => x.GetValue(request, null) != null)
                .ToDictionary(x => x.Name, x => x.GetValue(request, null));

            // Get names for all IEnumerable properties (excl. string)
            var propertyNames = properties
                .Where(x => !(x.Value is string) && x.Value is IEnumerable)
                .Select(x => x.Key)
                .ToList();

            // Concat all IEnumerable properties into a comma separated string
            foreach (var key in propertyNames)
            {
                var valueType = properties[key].GetType();
                var valueElemType = valueType.IsGenericType
                                        ? valueType.GetGenericArguments()[0]
                                        : valueType.GetElementType();
                if (valueElemType.IsPrimitive || valueElemType == typeof(string))
                {
                    var enumerable = properties[key] as IEnumerable;
                    properties[key] = string.Join(separator, enumerable.Cast<object>());
                }
            }

            // Concat all key/value pairs into a string separated by ampersand
            return string.Join("&", properties
                .Select(x => string.Concat(
                    Uri.EscapeDataString(x.Key), "=",
                    Uri.EscapeDataString(x.Value.ToString()))));
        }
    }
}