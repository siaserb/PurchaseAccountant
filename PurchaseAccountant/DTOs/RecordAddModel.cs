using System.ComponentModel.DataAnnotations;

namespace PurchaseAccountant.DTOs
{
    public class RecordAddModel
    {
        [Required]
        public int CategoryId { get; set; }
        public int? CurrencyId { get; set; }


        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Sum { get; set; }
    }
}
