using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrowdyFunding.Mvc.Startup))]
namespace CrowdyFunding.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
