using System.ComponentModel.DataAnnotations;

namespace ExpenceManagementSystem.Areas.Admin.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
