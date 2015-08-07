using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;
using CC.WEB.Areas.Admin.ViewModels.Shop;
using CC.WEB.Areas.Admin.ViewModels.Subtitles;

namespace CC.WEB.Areas.Admin.Controllers
{

    public class ShopCategoryController : Controller
    {
        private readonly IShopCategoryService _service;

        public ShopCategoryController(IShopCategoryService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var indexModel = new ShopCategoryIndexModel();
            indexModel.Load();

            return View(indexModel);
        }

        public ActionResult Details(int id)
        {
            var entity = _service.Find(id);
            return View(entity);
        }

        public ActionResult Create()
        {
            return View(new ShopCategoryCreateModel());
        }

        [HttpPost]
        public ActionResult Create(ShopCategoryCreateModel viewModel)
        {
            if (ModelState.IsValid) {
                _service.Create(viewModel.Category);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var entity = _service.Find(id);

            return View(new ShopCategoryEditModel(entity));
        }

        [HttpPost]
        public ActionResult Edit(ShopCategoryEditModel viewModel)
        {
            if (ModelState.IsValid) {
                _service.Update(viewModel.Category);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public ActionResult Delete(int id)
        {
            return View(_service.Find(id));
        }

        [HttpPost]
        public ActionResult Delete(ShopCategory viewModel)
        {
            if (ModelState.IsValid) {
                _service.Remove(viewModel.ShopCategoryId);

                return RedirectToAction("Index");
            }

            return View();
        }
    }

}
