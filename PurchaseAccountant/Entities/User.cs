using PurchaseAccountant.Entities.Base;

namespace PurchaseAccountant.Entities
{
    public class User : BaseEntity
    {
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public string Name { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
