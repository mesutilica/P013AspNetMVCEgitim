using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace P013AspNetMVCEgitim.Filters
{
    public class UserControl : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userGuid = context.HttpContext.Session.GetString("UserGuid"); // uygulamanın çalıştığı ekrandaki UserGuid isimli session ı yakala
            var userCookie = context.HttpContext.Request.Cookies["userguid"]; // cookie yi yakala
            if (userGuid == null)
            {
                context.Result = new RedirectResult("/MVC11Session?msg=AccessDenied");
            }
            base.OnActionExecuting(context);
        }
    }
}
