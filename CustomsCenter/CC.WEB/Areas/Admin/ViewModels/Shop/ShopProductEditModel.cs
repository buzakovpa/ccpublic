using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Shop
{

    public class ShopProductEditModel : ShopProductCreateModel
    {

        public ShopProductEditModel()
        {
        }

        public ShopProductEditModel(ShopProduct entity)
        {
            Product = entity;
        }

        public override string Title
        {
            get { return "Редактирование"; }
        }

    }

}