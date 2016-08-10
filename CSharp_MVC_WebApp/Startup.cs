using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharp_MVC_WebApp.Startup))]
namespace CSharp_MVC_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
