using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;

namespace CC.WEB.ViewModels
{

    public class ShopDetailsViewModel
    {

        public string Category { get; set; }
        public string CategoryTitle { get; set; }

        public string Product { get; set; }
        
        public List<ShopCategory> Categories { get; set; }
        public ShopProduct CurrentProduct { get; set; }

        public void Load()
        {
            var categoryService = DependencyResolver.Current.GetService<IShopCategoryService>();
            var productService = DependencyResolver.Current.GetService<IShopProductService>();

            Categories = categoryService.GetAll().Where(a => a.Show).ToList();
            
            CurrentProduct = productService.FindByAlias(Product);
            
            Category = CurrentProduct.Category.UrlAlias;
            CategoryTitle = CurrentProduct.Category.Title;
        }
    }

}