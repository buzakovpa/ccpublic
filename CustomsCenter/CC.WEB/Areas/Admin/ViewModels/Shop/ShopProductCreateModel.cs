using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CC.BUSINESS.Shop;
using CC.MODELS;

namespace CC.WEB.Areas.Admin.ViewModels.Shop
{

    public class ShopProductCreateModel
    {
        public virtual string Title
        {
            get { return "Создание"; }
        }

        public ShopProduct Product { get; set; }
        public List<SelectListItem> CategorySelectList { get; set; }

        public virtual void SetCategory()
        {
            var shopCategoryService = DependencyResolver.Current.GetService<IShopCategoryService>();
            CategorySelectList = shopCategoryService.GetAll()
                .Where(a => a.Show)
                .Select(a =>
                    new SelectListItem {
                        Text = a.Title,
                        Value = a.ShopCategoryId.ToString(),
                        Selected = Product!= null && Product.Category.ShopCategoryId == a.ShopCategoryId
                    })
                .ToList();
        }
    }

}