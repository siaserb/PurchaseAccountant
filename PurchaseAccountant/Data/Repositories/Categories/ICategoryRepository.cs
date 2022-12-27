using PurchaseAccountant.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseAccountant.Data.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task<int> AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> GetAllCategories(int userId);
    }
}
