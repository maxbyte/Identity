using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New.Startup))]
namespace New
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
