using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(planerApp.Startup))]
namespace planerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
