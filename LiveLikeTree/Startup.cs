using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveLikeTree.Startup))]
namespace LiveLikeTree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
