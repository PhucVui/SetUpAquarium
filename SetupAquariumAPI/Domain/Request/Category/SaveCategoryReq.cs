namespace SetupAquarium.Domain.Request.Category
{
    public class SaveCategoryReq
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Status { get; set; }
    }
}
