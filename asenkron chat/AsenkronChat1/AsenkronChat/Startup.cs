using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsenkronChat.Startup))]
namespace AsenkronChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
