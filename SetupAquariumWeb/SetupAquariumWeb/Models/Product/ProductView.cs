namespace SetupAquariumWeb.Models.Product
{
    public class ProductView
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string AvatarPath { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int AquariumSizeId { get; set; }
        public string Size { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }

    }
}
