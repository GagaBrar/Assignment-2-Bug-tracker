using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2Bugtracker.Startup))]
namespace Assignment2Bugtracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
