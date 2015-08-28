using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CC.MODELS;

namespace CC.WEB.Infrastructure.Helpers
{

    public static class ShopProductHelpers
    {
        public static List<ShopProductReview> GetReviews(this ShopProduct entity)
        {
            return entity.Reviews.Where(a => !a.IsDeleted && a.Show).ToList();
        }

        public static MvcHtmlString GetStars(this ShopProduct entity, bool showTitle = false)
        {
            var reviews = entity.GetReviews();

            int stars = 5;
            if (reviews.Any()) {
                stars = reviews.OrderByDescending(a => a.DateTime).First().Stars;
            }

            var format = "<p>" +
                                  "<span class='glyphicon glyphicon-star{0}'></span>" +
                                  "<span class='glyphicon glyphicon-star{1}'></span>" +
                                  "<span class='glyphicon glyphicon-star{2}'></span>" +
                                  "<span class='glyphicon glyphicon-star{3}'></span>" +
                                  "<span class='glyphicon glyphicon-star{4}'></span>" +
                                  (showTitle ? " {5} рейтинг" : "") +
                                  "</p>";

            return new MvcHtmlString(
                String.Format(format,
                    stars >= 1 ? "" : "-empty",
                    stars >= 2 ? "" : "-empty",
                    stars >= 3 ? "" : "-empty",
                    stars >= 4 ? "" : "-empty",
                    stars >= 5 ? "" : "-empty",
                    stars));
        }

        
    }

}