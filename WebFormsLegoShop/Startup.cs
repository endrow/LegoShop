using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsLegoShop.Startup))]
namespace WebFormsLegoShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
