using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FarmaciaMagañaBLL.Startup))]
namespace FarmaciaMagañaBLL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
