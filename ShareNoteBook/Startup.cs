using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShareNoteBook.Startup))]
namespace ShareNoteBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
