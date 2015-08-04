using CC.MODELS;

namespace CC.BUSINESS.Shop
{
    interface IShopCategoryService
    {
        ShopCategory Find(int id);
        ShopCategory Create(ShopCategory newcategory);
        ShopCategory Update(ShopCategory category);
        void Remove(int id);
    }

    interface IShopProductService
    {
        ShopProduct Find(int id);
        ShopProduct Create(ShopProduct newProduct);
        ShopProduct Update(ShopProduct product);
        void Remove(int id);
    }

}
