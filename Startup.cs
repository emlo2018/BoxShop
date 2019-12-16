using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoxShop.Startup))]
namespace BoxShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
