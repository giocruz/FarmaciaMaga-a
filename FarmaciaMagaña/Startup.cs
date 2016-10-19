using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FarmaciaMagaña.Startup))]
namespace FarmaciaMagaña
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
