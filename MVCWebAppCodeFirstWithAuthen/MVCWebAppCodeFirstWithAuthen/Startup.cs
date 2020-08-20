using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWebAppCodeFirstWithAuthen.Startup))]
namespace MVCWebAppCodeFirstWithAuthen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
