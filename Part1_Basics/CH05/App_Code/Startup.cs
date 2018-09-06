using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CH05.Startup))]
namespace CH05
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
