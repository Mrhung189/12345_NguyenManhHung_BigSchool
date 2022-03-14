using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_12345_NguyenManhHung_BigSchool.Startup))]
namespace _12345_NguyenManhHung_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
