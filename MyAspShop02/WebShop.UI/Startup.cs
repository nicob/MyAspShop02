using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShop.UI.Startup))]
namespace WebShop.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
