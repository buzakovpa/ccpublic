using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;

namespace CC.WEB.ViewModels
{

    public class ShopViewModel
    {

        public string Category { get; set; }

        public List<ShopCategory> Categories { get; set; }
        public List<ShopProduct> Products { get; set; }

        public void Load()
        {
            var categoryService = DependencyResolver.Current.GetService<IShopCategoryService>();

            Categories = categoryService.GetAll()
                .Where(a => a.Show)
                .ToList();
            if (Category == null) {
                var firstCategory = Categories.FirstOrDefault();
                if (firstCategory != null) {
                    Category = firstCategory.UrlAlias;
                }
            }

            var selectedCategory = Categories.FirstOrDefault(a => a.UrlAlias == Category);
            if (selectedCategory != null) {
                Products = selectedCategory.Products.Where(a => !a.IsDeleted && a.Show).ToList();
            }
        }
    }

}