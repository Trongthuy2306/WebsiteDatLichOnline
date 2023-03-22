using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocTorOnline.Startup))]
namespace DocTorOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
