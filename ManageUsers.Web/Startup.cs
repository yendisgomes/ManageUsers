using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageUsers.Web.Startup))]
namespace ManageUsers.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
