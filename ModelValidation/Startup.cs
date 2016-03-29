using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModelValidation.Startup))]
namespace ModelValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
