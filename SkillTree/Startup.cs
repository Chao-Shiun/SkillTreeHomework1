using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkillTree.Startup))]
namespace SkillTree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
