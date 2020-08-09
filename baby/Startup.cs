using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baby.Startup))]
namespace baby
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
