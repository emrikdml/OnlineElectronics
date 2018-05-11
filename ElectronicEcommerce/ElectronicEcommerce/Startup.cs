using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectronicEcommerce.Startup))]
namespace ElectronicEcommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
