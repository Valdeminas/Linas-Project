using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinoMvc.Startup))]
namespace LinoMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
