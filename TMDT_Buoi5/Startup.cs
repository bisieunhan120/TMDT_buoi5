using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_Buoi5.Startup))]
namespace TMDT_Buoi5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
