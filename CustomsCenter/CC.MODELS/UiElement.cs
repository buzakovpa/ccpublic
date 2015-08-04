using System.ComponentModel.DataAnnotations;

namespace CC.MODELS
{

    public class UiElement
    {
        public int UiElementId { get; set; }

        public int Alias { get; set; }
        public string Value { get; set; }

        public bool Show { get; set; }

        public enum Aliass : int
        {
            [Display(Name = @"Магазин")] Shop = 10,
            [Display(Name = @"Детали магазина")] ShopDetails = 11,

            AdminShop = 110,
            AdminShopDetails = 111,
            AdminShopCreate = 112,
            AdminShopEdit = 113,
            AdminShopDelete = 114,
        }

    }

}