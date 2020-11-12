namespace SetupAquarium.Domain.Request.Product
{
    public class SaveProductReq
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string AvatarPath { get; set; }
        public int CategoryId { get; set; }
        public int AquariumSizeId { get; set; }
        public int Status { get; set; }
    }
}
