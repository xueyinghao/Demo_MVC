using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_MVC.Startup))]
namespace Demo_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
