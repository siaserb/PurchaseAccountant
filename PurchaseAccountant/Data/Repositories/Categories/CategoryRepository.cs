using Microsoft.EntityFrameworkCore;
using PurchaseAccountant.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseAccountant.Data.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddCategoryAsync(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();

            return category.Id;
        }

        public async Task<IEnumerable<Category>> GetAllCategories(int userId)
        {
            return await _dbContext.Categories.Where(item => item.UserId == userId).ToListAsync();
        }
    }
}
