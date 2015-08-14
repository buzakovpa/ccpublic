using System.Collections.Generic;
using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Shop
{

    public class ShopProductIndexModel
    {

        public string Title
        {
            get { return "Список товаров"; }
        }

        public List<ShopProduct> Products { get; set; }

        public void Load( )
        {
            var shopProductService = DependencyResolver.Current.GetService<IShopProductService>( );
            Products = shopProductService.GetAll( );
        }
    }

}