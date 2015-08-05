using CC.BUSINESS.Shop;
using Ninject.Modules;

namespace CC.BUSINESS
{

    public class BusinessNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUiElementService>().To<UiElementService>();

            Bind<IShopCategoryService>().To<ShopCategoryService>( );
            Bind<IShopProductService>().To<ShopProductService>();
            Bind<IShopProductReviewService>().To<ShopProductReviewService>();
        }
    }

}