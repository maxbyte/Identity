using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapFlat.Startup))]
namespace BootstrapFlat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
