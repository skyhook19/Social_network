using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Books_01.Startup))]

namespace Books_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
