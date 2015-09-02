using System.Web.Mvc;
using CC.WEB.ViewModels;

namespace CC.WEB.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index(AboutViewModel viewModel)
        {
            viewModel.Load();
            
            return View(viewModel);
        }
	}
}