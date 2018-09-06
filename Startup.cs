using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab26Auth.Startup))]
namespace Lab26Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
