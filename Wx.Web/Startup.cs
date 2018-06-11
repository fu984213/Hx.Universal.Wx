using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wx.Web.Startup))]
namespace Wx.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
