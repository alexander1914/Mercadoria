using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMercado.Startup))]
namespace AppMercado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
