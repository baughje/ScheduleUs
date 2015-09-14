using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScheduleUs.Startup))]
namespace ScheduleUs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
