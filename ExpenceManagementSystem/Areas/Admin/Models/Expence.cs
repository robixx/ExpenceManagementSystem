using System.ComponentModel.DataAnnotations;

namespace ExpenceManagementSystem.Areas.Admin.Models
{
    public class Expence
    {
        [Key]
        public int ExpenceId { get; set; }
        public string? ExpanceTitle { get; set; }
        public int CategoryId { get; set; }
        public decimal? Amount { get; set; }

        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
