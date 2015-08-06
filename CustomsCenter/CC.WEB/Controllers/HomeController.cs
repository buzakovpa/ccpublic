using System.Web.Mvc;

namespace CC.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InDeveloping()
        {
            return View();
        }
    }
}