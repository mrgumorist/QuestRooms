using System;
using System.Threading.Tasks;
using QuestRooms.UI.App_Start;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using QuestRooms.DAL;
using QuestRooms.UI.App_Start;

[assembly: OwinStartup(typeof(QuestRooms.UI.Startup))]

namespace QuestRooms.UI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(RoomsContext.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                //Если нет прав то редирект по ссылке
                LoginPath = new PathString("/Home/Index?PageId=1")

            });
        }
    }
}
