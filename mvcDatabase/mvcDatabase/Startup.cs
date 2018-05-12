using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcDatabase.Startup))]
namespace mvcDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
