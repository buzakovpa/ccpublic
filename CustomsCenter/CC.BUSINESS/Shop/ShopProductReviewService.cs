using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS.Shop
{

    class ShopProductReviewService : SoftDeleteEntityService<ShopProductReview>, IShopProductReviewService
    {

        public ShopProductReviewService(AppContext context) : base(context)
        {
        }

    }

}