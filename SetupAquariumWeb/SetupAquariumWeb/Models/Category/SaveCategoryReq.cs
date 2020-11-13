using System.ComponentModel.DataAnnotations;

namespace SetupAquariumWeb.Models.Category
{
    public class SaveCategoryReq
    {
        public int CategoryId { get; set; }
        [Required]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
