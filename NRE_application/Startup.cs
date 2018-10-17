using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NRE_application.Startup))]
namespace NRE_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        //test
    }
}
