//Sam is a fucken numpty

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechPortal.Startup))]
namespace TechPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
