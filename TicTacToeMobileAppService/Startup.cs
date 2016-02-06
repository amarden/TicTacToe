using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TicTacToeMobileAppService.Startup))]

namespace TicTacToeMobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}