using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB23_TranCongMinh.Startup))]
namespace LAB23_TranCongMinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
