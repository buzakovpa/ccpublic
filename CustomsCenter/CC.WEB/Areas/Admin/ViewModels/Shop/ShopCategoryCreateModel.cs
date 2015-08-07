using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Shop
{

    public class ShopCategoryCreateModel
    {
        public virtual string Title
        {
            get { return "Создание"; }
        }

        public ShopCategory Category { get; set; }

    }

}