using System;

namespace CC.MODELS
{

    public class ShopProductReview : IDeletedEntity
    {
        public int ShopProductReviewId { get; set; }

        public bool Show { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime DateTime { get; set; }
        public int Stars { get; set; }

        public virtual ShopProduct Product { get; set; }

        public bool IsDeleted { get; set; }
    }

}