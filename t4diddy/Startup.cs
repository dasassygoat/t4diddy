using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(t4diddy.Startup))]
namespace t4diddy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
