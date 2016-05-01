using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSCI467PlaceOrderWeb.Startup))]
namespace CSCI467PlaceOrderWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
