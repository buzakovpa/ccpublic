using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Shop
{

    public class ShopCategoryEditModel : ShopCategoryCreateModel
    {

        public override string Title
        {
            get { return "Редактирование"; }
        }

        public ShopCategoryEditModel()
        {
        }

        public ShopCategoryEditModel(ShopCategory element)
        {
           Category = element;
        }
    }

}