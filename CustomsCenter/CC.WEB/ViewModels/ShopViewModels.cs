using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;

namespace CC.WEB.ViewModels
{
    public class ShopViewModel
    {

        public string Alias { get; set; }

        public List<ShopCategory> Categories { get; set; }

        public void Load()
        {
            var categoryService = DependencyResolver.Current.GetService<IShopCategoryService>();

            Categories = categoryService.GetAll()
                .Where(a => a.Show)
                .ToList();
            if (Alias == null) {
                var firstCategory = Categories.FirstOrDefault();
                if (firstCategory != null) {
                    Alias = firstCategory.UrlAlias;
                }
            }
        }
    }

    public class ShopDetailsViewModel
    {

        public string Alias { get; set; }
        public string CategoryName { get; set; }
        public List<ShopCategory> Categories { get; set; }

        public void Load()
        {
            var categoryService = DependencyResolver.Current.GetService<IShopCategoryService>();

            Categories = categoryService.GetAll()
                .Where(a => a.Show)
                .ToList();

            if (Alias == null) {
                var firstCategory = Categories.FirstOrDefault();
                if (firstCategory != null) {
                    Alias = firstCategory.UrlAlias;
                }
            }

            var selectedCategory = Categories.FirstOrDefault(a => a.UrlAlias == Alias);
            if (selectedCategory != null) {
                CategoryName = selectedCategory.Title;
            }
        }
    }
}