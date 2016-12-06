using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MobileAppService.Startup))]

namespace MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}