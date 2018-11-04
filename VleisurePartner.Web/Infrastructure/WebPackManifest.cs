using System.Web.Hosting;

namespace VleisurePartner.Web.Infrastructure
{
    public static class WebPackManifest
    {
        public static dynamic GetManifest()
        {
            var manifest = System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/dist/manifest.json"));
            return Newtonsoft.Json.JsonConvert.DeserializeObject(manifest);
        }
    }
}