using Microsoft.Owin;
using Owin;
using System.Net;

[assembly: OwinStartup(typeof(VleisurePartner.Web.App_Start.Startup))]
namespace VleisurePartner.Web.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            //ConfigureAuth(app);
        }
    }
}
