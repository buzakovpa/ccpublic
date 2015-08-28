using System.Web.Mvc;
using CC.WEB.Infrastructure.Filters;

namespace CC.WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new UtmFilter());
        }
    }
}
