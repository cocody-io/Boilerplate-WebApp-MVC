using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quality.WebApp.Startup))]
namespace Quality.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
