namespace PurchaseAccountant.DTOs.Auth
{
    public class RegistrationModel
    {
        public int CurrencyId { get; set; }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
