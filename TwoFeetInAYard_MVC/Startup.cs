using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwoFeetInAYard_MVC.Startup))]
namespace TwoFeetInAYard_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
