using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CC.WEB.Startup))]
namespace CC.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
