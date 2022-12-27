using PurchaseAccountant.Entities;
using System.Threading.Tasks;

namespace PurchaseAccountant.Data.Repositories.Users
{
    public interface IUserRepository
    {
        Task<bool> UserWithSuchLoginExists(string login);
        Task<User> FindUserByLoginAsync(string login);
        Task ChangeUserDefaultСurrencyAsync(int userId, int currencyId);
        Task<int> GetUserDefaultСurrencyAsync(int userId);
        Task AddUserAsync(User user);
    }
}
