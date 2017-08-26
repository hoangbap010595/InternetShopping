using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCShopping2017.Startup))]
namespace MVCShopping2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
