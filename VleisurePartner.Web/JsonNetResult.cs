using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VleisurePartner.Web
{
    public class JsonNetResult : JsonResult
    {
        private readonly JsonSerializerSettings _settings;

        public JsonNetResult(bool serializeWithCamelCasing = false)
        {
            _settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = serializeWithCamelCasing ? new CamelCasePropertyNamesContractResolver() : new DefaultContractResolver()
            };
        }

        public JsonNetResult(JsonResult jsonResult) : this(true)
        {
            ContentEncoding = jsonResult.ContentEncoding;
            ContentType = jsonResult.ContentType;
            Data = jsonResult.Data;
            JsonRequestBehavior = jsonResult.JsonRequestBehavior;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if ((JsonRequestBehavior == JsonRequestBehavior.DenyGet)
                && context.HttpContext.Request.HttpMethod.EqualsIgnoreCase("GET"))
            {
                base.ExecuteResult(context);
            }

            var response = context.HttpContext.Response;
            response.ContentType = ContentType.DefaultTo("application/json");

            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            if (Data == null)
            {
                return;
            }

            JsonSerializer.Create(_settings).Serialize(response.Output, Data);
        }
    }
}