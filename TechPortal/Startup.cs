//Sam is a fucken numpty

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Techportal.Startup))]
namespace Techportal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
