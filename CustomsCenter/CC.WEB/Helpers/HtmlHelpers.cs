using System.Web.Mvc;
using CC.BUSINESS;
using CC.MODELS;

namespace CC.WEB.Helpers
{

    public static class HtmlHelpers
    {
        public static string GetSubtitles(this HtmlHelper htmlHelper, UiElement.Aliass alias)
        {
            var elementService = DependencyResolver.Current.GetService<IUiElementService>();

            var entity = elementService.Find(alias);

            return entity == null ? "" : (entity.Value ?? "");
        }
    }

}