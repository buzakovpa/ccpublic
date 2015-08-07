using System.Collections.Generic;
using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Shop
{
    public class ShopCategoryIndexModel
    {

        public string Title
        {
            get { return "Категории товаров"; }
        }

        public List<ShopCategory> Categories { get; set; }

        public void Load()
        {
            var shopCategoryService = DependencyResolver.Current.GetService<IShopCategoryService>();
            Categories = shopCategoryService.GetAll();
        }
    }
}