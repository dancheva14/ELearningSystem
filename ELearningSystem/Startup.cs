using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELearningSystem.Startup))]
namespace ELearningSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
