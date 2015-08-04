using System.ComponentModel.DataAnnotations;

namespace CC.MODELS
{

    public class UiImage
    {
        public int UiImageId { get; set; }

        public int Alias { get; set; }
        public string Folder { get; set; }
        public string Filename { get; set; }

        public bool Show { get; set; }

        public enum Aliass : int
        {
            [Display(Name = "Shop [1140x300]")] Shop1140X300 = 10,
            [Display(Name = "Shop Details [840x300]")] ShopDetails840X300 = 11,
        }
    }

}