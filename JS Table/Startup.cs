using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JS_Table.Startup))]
namespace JS_Table
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
