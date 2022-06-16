using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan5_NguyenThanhDat.Startup))]
namespace Tuan5_NguyenThanhDat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
