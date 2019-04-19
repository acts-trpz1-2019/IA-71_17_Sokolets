using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NDCShop.Startup))]
namespace NDCShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
