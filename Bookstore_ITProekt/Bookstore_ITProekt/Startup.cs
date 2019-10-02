using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookstore_ITProekt.Startup))]
namespace Bookstore_ITProekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
