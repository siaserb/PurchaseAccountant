using System;

namespace PurchaseAccountant.DTOs
{
    public class RecordResponse
    {
        public int CategoryId { get; set; }
        public int CurrencyId { get; set; }

        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Sum { get; set; }
    }
}
