using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jyy201831980105.Startup))]
namespace Jyy201831980105
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
