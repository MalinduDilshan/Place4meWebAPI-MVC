using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Place4me.Startup))]
namespace Place4me
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
