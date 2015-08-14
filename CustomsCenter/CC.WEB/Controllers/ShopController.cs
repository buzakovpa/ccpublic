using System.Web.Mvc;
using CC.WEB.ViewModels;

namespace CC.WEB.Controllers
{

    public class ShopController : Controller
    {
        public ActionResult Index(ShopViewModel viewmodel)
        {
            viewmodel.Load();

            return View(viewmodel);
        }

        public ActionResult Details(ShopDetailsViewModel viewmodel)
        {
            viewmodel.Load();

            return View(viewmodel);
        }
    }

}