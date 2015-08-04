using System.Data.Entity.Migrations;
using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS.Shop
{

    public class ShopProductReviewService : BaseEntityService, IShopProductReviewService
    {

        public ShopProductReviewService(AppContext context) : base(context)
        {
        }

        public ShopProductReview Find(int id)
        {
            return Context.ShopProductReviews.Find(id);
        }

        public ShopProductReview Create(ShopProductReview newReview)
        {
            Context.ShopProductReviews.Add(newReview);
            Context.SaveChanges();

            return newReview;
        }

        public ShopProductReview Update(ShopProductReview review)
        {
            Context.ShopProductReviews.AddOrUpdate(review);
            Context.SaveChanges();

            return review;
        }

        public void Remove(int id)
        {
            var entity = Find(id);
            
            Context.ShopProductReviews.Remove(entity);
            Context.SaveChanges();
        }
    }

}