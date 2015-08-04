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
            Shop = 10,
            ShopDetails = 11,

            AdminShop = 110,
            AdminShopDetails = 111,
            AdminShopCreate = 112,
            AdminShopEdit = 113,
            AdminShopDelete = 114,
        }

    }

}