using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(STA.SuperCompra.UI.Mvc.Startup))]
namespace STA.SuperCompra.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
