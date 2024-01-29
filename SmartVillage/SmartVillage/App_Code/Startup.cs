using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartVillage.Startup))]
namespace SmartVillage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
