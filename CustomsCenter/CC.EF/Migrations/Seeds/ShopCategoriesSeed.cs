using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using CC.MODELS;

namespace CC.EF.Migrations.Seeds
{

    public class ShopCategoriesSeed : ISeed
    {
        public void Seed(AppContext context)
        {
            var categories = new List<ShopCategory> {
                new ShopCategory {
                    UrlAlias = "аксессуары",
                    Title = "Аксессуары",
                    Show= true,
                },

                new ShopCategory {
                    UrlAlias = "одежда",
                    Title = "Одежда",
                    Show= true,
                },

                new ShopCategory {
                    UrlAlias = "номерные-рамки",
                    Title = "Номерные рамки",
                    Show= true,
                },

                new ShopCategory {
                    UrlAlias = "наклейки",
                    Title = "Наклейки",
                    Show= true,
                },

                new ShopCategory {
                    UrlAlias = "тюнинг",
                    Title = "Тюнинг",
                    Show= true,
                },

                new ShopCategory {
                    UrlAlias = "idemitsu",
                    Title = "Idemitsu",
                    Show= true,
                },
            };

            foreach (var item in categories) {
                var entity = context.ShopCategories.FirstOrDefault(a => a.UrlAlias == item.UrlAlias);
                if (entity == null) {
                    context.ShopCategories.Add(item);
                }
                else {
                    entity.Title = item.Title;
                    entity.Show = item.Show;
                }
            }
        }
    }

}