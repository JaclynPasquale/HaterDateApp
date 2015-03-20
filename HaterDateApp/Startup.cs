using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaterDateApp.Startup))]
namespace HaterDateApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
