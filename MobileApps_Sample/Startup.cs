using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MobileApps_Sample.Startup))]

namespace MobileApps_Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}