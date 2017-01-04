using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contoso01.Startup))]
namespace Contoso01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
