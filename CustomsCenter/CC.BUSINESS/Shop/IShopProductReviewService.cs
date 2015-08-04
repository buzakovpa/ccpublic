using CC.MODELS;

namespace CC.BUSINESS.Shop
{

    interface IShopProductReviewService
    {
        ShopProductReview Find(int id);
        ShopProductReview Create(ShopProductReview newReview);
        ShopProductReview Update(ShopProductReview review);
        void Remove(int id);
    }

}