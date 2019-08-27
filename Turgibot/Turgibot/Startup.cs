using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Turgibot.Startup))]
namespace Turgibot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
