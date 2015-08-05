using System.Web.Mvc;
using CC.BUSINESS;
using CC.MODELS;
using CC.WEB.Areas.Admin.ViewModels.Subtitles;

namespace CC.WEB.Areas.Admin.Controllers
{

    public class SubtitlesController : Controller
    {
        private readonly IUiElementService _service;

        public SubtitlesController(IUiElementService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var indexModel = new SubtitlesIndexModel();
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
            return View(new SubtitlesCreateModel());
        }

        [HttpPost]
        public ActionResult Create(SubtitlesCreateModel viewModel)
        {
            if (ModelState.IsValid) {
                _service.Create(viewModel.Element);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var entity = _service.Find(id);

            return View(new SubtitlesEditModel(entity));
        }

        [HttpPost]
        public ActionResult Edit(SubtitlesEditModel viewModel)
        {
            if (ModelState.IsValid) {
                _service.Update(viewModel.Element);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public ActionResult Delete(int id)
        {
            return View(_service.Find(id));
        }

        [HttpPost]
        public ActionResult Delete(UiElement viewModel)
        {
            if (ModelState.IsValid) {
                _service.Remove(viewModel.UiElementId);

                return RedirectToAction("Index");
            }

            return View();
        }
    }

}
