using System.Collections.Generic;

namespace CC.MODELS
{

    public class ShopProduct : IDeletedEntity
    {
        public int ShopProductId { get; set; }
        public string UrlAlias { get; set; }

        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool Show { get; set; }

        public double PurchasePrice { get; set; }
        public double SellingPrice { get; set; }

        public virtual UiImage Image320X150 { get; set; }
        public virtual UiImage Image840X300 { get; set; }
        public virtual List<ShopProductReview> Reviews { get; set; }
        public virtual ShopCategory Category { get; set; }

        public bool IsDeleted { get; set; }
    }

}