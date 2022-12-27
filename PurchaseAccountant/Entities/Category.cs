using PurchaseAccountant.Entities.Base;

namespace PurchaseAccountant.Entities
{
    public class Category : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public string Name { get; set; }
    }
}
