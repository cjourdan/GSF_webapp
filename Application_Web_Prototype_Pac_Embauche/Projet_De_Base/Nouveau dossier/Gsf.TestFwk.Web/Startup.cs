using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gsf.TestFwk.Web.Startup))]
namespace Gsf.TestFwk.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
