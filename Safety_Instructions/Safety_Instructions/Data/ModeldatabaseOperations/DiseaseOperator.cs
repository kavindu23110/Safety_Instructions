using Safety_Instructions.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.ModeldatabaseOperations
{
    public class DiseaseOperator : DatabaseOperation<Disease>
    {
        public DiseaseOperator(ref SQLiteAsyncConnection database) : base(ref database)
        {
            _database.CreateTableAsync<Disease>().Wait();
        }
        public override Task<List<Disease>> FindAsync(Expression<Func<Disease, bool>> predicate)
        {
            return _database.Table<Disease>()
                  .Where(predicate).ToListAsync();
        }

        public override Task<List<Disease>> GetAsync()
        {
            return _database.Table<Disease>().ToListAsync();
        }

        public override Task<Disease> GetSelectedAsync(Expression<Func<Disease, bool>> predicate)
        {
            return _database.Table<Disease>()
                              .Where(predicate)
                              .FirstOrDefaultAsync();
        }
    }
}
