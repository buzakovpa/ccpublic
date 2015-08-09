using System.Collections.Generic;
using CC.EF.Migrations.Seeds;
using CC.MODELS;

namespace CC.EF.Migrations
{

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CC.EF.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CC.EF.AppContext context)
        {
            var seeds = new List<ISeed> {
                new ShopCategoriesSeed()
            };

            foreach (var item in seeds) {
                item.Seed(context);
            }

            context.SaveChanges();
        }
    }

}