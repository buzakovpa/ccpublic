using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS.Shop
{

    class ShopProductService : SoftDeleteEntityService<ShopProduct>, IShopProductService
    {
        public ShopProductService(AppContext context) : base(context)
        {
        }
    }

}