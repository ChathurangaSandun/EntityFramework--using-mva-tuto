using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(new_1.Startup))]
namespace new_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
