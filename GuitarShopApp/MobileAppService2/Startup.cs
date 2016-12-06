using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MobileAppService2.Startup))]

namespace MobileAppService2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}