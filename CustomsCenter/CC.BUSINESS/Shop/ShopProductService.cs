using System.Data.Entity.Migrations;
using System.Linq;
using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS.Shop
{

    internal class ShopProductService : SoftDeleteEntityService<ShopProduct>, IShopProductService
    {
        public ShopProductService(AppContext context) : base(context)
        {
        }

        public ShopProduct FindByAlias(string alias)
        {
            return DbSet.FirstOrDefault(a => a.UrlAlias == alias);
        }

        public override ShopProduct Create(ShopProduct newEntity)
        {
            var category = Context.ShopCategories.Find(newEntity.Category.ShopCategoryId);
            newEntity.Category = category;

            return base.Create(newEntity);
        }

        public override ShopProduct Update(ShopProduct entity)
        {
            //DbSet.AddOrUpdate(entity);
            Context.SaveChanges();

            return entity;
        }
    }

}