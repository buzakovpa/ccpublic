using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Subtitles
{

    public class SubtitlesEditModel : SubtitlesCreateModel
    {

        public override string Title
        {
            get { return "Редактирование"; }
        }

        public SubtitlesEditModel()
        {
        }

        public SubtitlesEditModel(UiElement element)
        {
            Element = element;
            Alias = (UiElement.Aliass)element.Alias;
        }
    }

}