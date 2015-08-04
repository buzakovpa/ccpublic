using System.Collections.Generic;

namespace CC.MODELS
{

    public class ShopCategory : IDeletedEntity
    {
        public int ShopCategoryId { get; set; }

        public string Title { get; set; }
        public bool Show { get; set; }

        public virtual List<ShopProduct> Products { get; set; }

        public bool IsDeleted { get; set; }
    }

}