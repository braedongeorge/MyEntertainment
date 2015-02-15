using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEntertainment.Startup))]
namespace MyEntertainment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
