using System.Linq;
using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;
using CC.WEB.Areas.Admin.ViewModels.Shop;

namespace CC.WEB.Areas.Admin.Controllers
{

    public class ShopProductController : Controller
    {
        private readonly IShopProductService _service;
        private readonly IShopCategoryService _categoryService;

        public ShopProductController(IShopProductService service, IShopCategoryService categoryService)
        {
            _service = service;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var indexmodel = new ShopProductIndexModel();
            indexmodel.Load();

            return View(indexmodel);
        }

        [ValidateInput(false)]  
        public ActionResult Details(int id)
        {
            var entity = _service.Find(id);
            return View(entity);
        }

        [ValidateInput(false)]  
        public ActionResult Create()
        {
            var viewmodel = new ShopProductCreateModel();
            viewmodel.SetCategory();

            return View(viewmodel);
        }

        [HttpPost]
        [ValidateInput(false)]  
        public ActionResult Create(ShopProductCreateModel viewmodel)
        {
            if (ModelState.IsValid) {
                _service.Create(viewmodel.Product);

                return RedirectToAction("Index");
            }

            return View(viewmodel);
        }

        [ValidateInput(false)]
        public ActionResult Edit(int id)
        {
            var entity = _service.Find(id);
            var viewmodel = new ShopProductEditModel(entity);
            viewmodel.SetCategory();

            return View(viewmodel);
        }

//        1439051577.0410587.8bc939b7a78c4edb80aa033f7c128238
//
        [HttpPost]
        [ValidateInput(false)]  
        public ActionResult Edit(ShopProductEditModel viewModel)
        {
            if (ModelState.IsValid) {
                var entity = _service.Find(viewModel.Product.ShopProductId);

                entity.Category = _categoryService.Find(viewModel.Product.Category.ShopCategoryId);
                
                entity.UrlAlias = viewModel.Product.UrlAlias;
                entity.Title = viewModel.Product.Title;
                entity.ShortDescription = viewModel.Product.ShortDescription;
                entity.FullDescription = viewModel.Product.FullDescription;
                entity.Show = viewModel.Product.Show;
                entity.PurchasePrice = viewModel.Product.PurchasePrice;
                entity.SellingPrice = viewModel.Product.SellingPrice;

                _service.Update(entity);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        [ValidateInput(false)]  
        public ActionResult Delete(int id)
        {
            return View(_service.Find(id));
        }

        [HttpPost]
        [ValidateInput(false)]  
        public ActionResult Delete(ShopProduct viewModel)
        {
            if (ModelState.IsValid) {
                _service.Remove(viewModel.ShopProductId);

                return RedirectToAction("Index");
            }

            return View();
        }
    }

}
