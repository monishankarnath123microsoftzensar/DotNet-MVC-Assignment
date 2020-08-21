using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWebAppWithAuthen.Startup))]
namespace MVCWebAppWithAuthen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
