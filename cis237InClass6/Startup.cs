using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cis237InClass6.Startup))]
namespace cis237InClass6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
