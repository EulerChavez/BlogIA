using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogIA.Startup))]
namespace BlogIA {

    public partial class Startup {

        public void Configuration(IAppBuilder app) {

            ConfigureAuth(app);

            app.MapSignalR();

        }

    }

}
