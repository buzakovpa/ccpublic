using System.Web.Mvc;
using CC.WEB.Infrastructure.Extensions;

namespace CC.WEB.Infrastructure.Filters
{
    public class UtmFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var utmNames = new[]
            {
                "utm_source",
                "utm_medium",
                "utm_campaign",
                "utm_content",
                "utm_term"
            };

            foreach (var utmName in utmNames)
            {
                var utmValue = filterContext.GetRequestRoute(utmName);
                if (utmValue != null)
                {
                    filterContext.SetCookie(utmName, utmValue);
                }
            }

            base.OnActionExecuting(filterContext);
        }

    }
}