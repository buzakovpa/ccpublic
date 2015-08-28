using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CC.WEB.Infrastructure.Extensions
{
    public static class ActionExecutingContextExtensions
    {
        public static string GetRequestRoute(this ActionExecutingContext context, string key) 
        {
            return context.HttpContext.Request[key];
        }

        public static void SetCookie(this ActionExecutingContext context, string key, string value)
        {
            if (context.HttpContext.Request.Cookies.AllKeys.Contains(key) == false)
            {
                var cookie = new HttpCookie(key, value);
                context.HttpContext.Response.Cookies.Add(cookie);
            } else
            {
                var httpCookie = context.HttpContext.Response.Cookies[key];
                if (httpCookie != null)
                {
                    httpCookie.Value = value;
                }
            }
        }
    }
}