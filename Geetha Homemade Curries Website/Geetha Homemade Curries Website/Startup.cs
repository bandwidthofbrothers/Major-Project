using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Geetha_Homemade_Curries_Website.Startup))]
namespace Geetha_Homemade_Curries_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
