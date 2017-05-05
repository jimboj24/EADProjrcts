using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProStatsWeb.Startup))]
namespace ProStatsWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
