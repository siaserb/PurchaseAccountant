using PurchaseAccountant.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseAccountant.Data.Repositories.Currencies
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetAllCategories();
    }
}
