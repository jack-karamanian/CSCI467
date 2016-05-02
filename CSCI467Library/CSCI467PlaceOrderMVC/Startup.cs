using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSCI467PlaceOrderMVC.Startup))]
namespace CSCI467PlaceOrderMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
