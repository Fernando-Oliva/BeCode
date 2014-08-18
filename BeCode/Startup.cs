using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeCode.Startup))]
namespace BeCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
