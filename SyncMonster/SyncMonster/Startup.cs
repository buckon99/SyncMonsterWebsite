using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyncMonster.Startup))]
namespace SyncMonster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
