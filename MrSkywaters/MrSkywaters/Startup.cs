using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MrSkywaters.Startup))]
namespace MrSkywaters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
