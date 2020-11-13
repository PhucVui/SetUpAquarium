using System.ComponentModel.DataAnnotations;

namespace SetupAquariumWeb.Models.Product
{
    public class SaveProductReq
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        public float Price { get; set; }
        [Display(Name = "Avatar")]
        public string AvatarPath { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int AquariumSizeId { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
