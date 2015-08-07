using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Subtitles
{

    public class SubtitlesCreateModel
    {
        public virtual string Title
        {
            get { return "Создание"; }
        }

        public UiElement.Aliass Alias { get; set; }

        public UiElement Element { get; set; }

    }

}