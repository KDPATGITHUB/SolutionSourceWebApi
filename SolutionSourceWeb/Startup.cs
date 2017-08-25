using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolutionSourceWeb.Startup))]
namespace SolutionSourceWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
