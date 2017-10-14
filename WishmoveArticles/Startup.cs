using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WishmoveArticles.Startup))]
namespace WishmoveArticles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
