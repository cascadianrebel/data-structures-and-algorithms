using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab41MvcMovie.Startup))]
namespace Lab41MvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
