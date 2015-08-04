using System.Collections.Generic;
using System.Web.Mvc;
using CC.BUSINESS;
using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Subtitles
{

    public class SubtitlesIndexModel
    {
        public string Title
        {
            get { return "Подзаголовки"; }
        }

        public List<UiElement> UiElements { get; set; }

        public void Load()
        {
            var uielementService = DependencyResolver.Current.GetService<IUiElementService>();
            UiElements = uielementService.GetAll();
        }
    }

}