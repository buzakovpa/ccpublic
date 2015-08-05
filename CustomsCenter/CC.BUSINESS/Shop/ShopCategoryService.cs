using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS.Shop
{

    class ShopCategoryService : SoftDeleteEntityService<ShopCategory>, IShopCategoryService
    {
        public ShopCategoryService(AppContext context) : base(context)
        {
        }
    }

}