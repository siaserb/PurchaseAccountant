using Microsoft.EntityFrameworkCore;
using PurchaseAccountant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseAccountant.Data.Repositories.Records
{
    public class RecordRepository : IRecordRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public RecordRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddRecordAsync(Record record)
        {
            record.CreatedOn = DateTime.Now;

            _dbContext.Records.Add(record);
            await _dbContext.SaveChangesAsync();

            return record.Id;
        }

        public async Task<IEnumerable<Record>> GetRecordsByUserId(int userId)
        {
            var record = await _dbContext.Records.Where(r => r.UserId == userId).ToListAsync();

            if (record == null)
            {
                throw new System.Exception("No record with such Id");
            }

            return record;
        }

        public async Task<IEnumerable<Record>> GetRecordsByUserIdAndCategoryId(int userId, int categoryId)
        {
            return await _dbContext.Records
                .Where(r => r.UserId == userId && r.CategoryId == categoryId)
                .ToListAsync();
        }
    }
}
