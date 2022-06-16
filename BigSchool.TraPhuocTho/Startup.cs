using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool.TraPhuocTho.Startup))]
namespace BigSchool.TraPhuocTho
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
