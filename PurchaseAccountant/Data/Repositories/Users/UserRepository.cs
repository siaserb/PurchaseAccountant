using Microsoft.EntityFrameworkCore;
using PurchaseAccountant.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseAccountant.Data.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> UserWithSuchLoginExists(string login)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(item => item.Login == login) != null;
        }

        public async Task AddUserAsync(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> FindUserByLoginAsync(string login)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(item => item.Login == login);
        }

        public async Task ChangeUserDefaultСurrencyAsync(int userId, int currencyId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if (user == null)
            {
                throw new System.Exception("No user with such Id");
            }

            user.CurrencyId = currencyId;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> GetUserDefaultСurrencyAsync(int userId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if (user == null)
            {
                throw new System.Exception("No user with such Id");
            }

            return user.CurrencyId;
        }
    }
}
