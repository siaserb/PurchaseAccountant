using PurchaseAccountant.Entities.Base;
using System;

namespace PurchaseAccountant.Entities
{
    public class Record : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Sum { get; set; }
    }
}
