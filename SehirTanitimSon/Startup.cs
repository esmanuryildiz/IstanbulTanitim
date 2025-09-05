using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SehirTanitimSon.Startup))]
namespace SehirTanitimSon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
