using Safety_Instructions.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.ModeldatabaseOperations
{
    public class InstructionOperator : DatabaseOperation<Instructions>

    {
        public InstructionOperator(ref SQLiteAsyncConnection database) : base(ref database)
        {
            _database.CreateTableAsync<Instructions>().Wait();
        }
        public override Task<List<Instructions>> FindAsync(Expression<Func<Instructions, bool>> predicate)
        {
            return _database.Table<Instructions>()
                .Where(predicate).ToListAsync();
            
        }

        public override Task<List<Instructions>> GetAsync()
        {
            return _database.Table<Instructions>().ToListAsync();
        }

        public override Task<Instructions> GetSelectedAsync(Expression<Func<Instructions, bool>> predicate)
        {
            return _database.Table<Instructions>()
                    .Where(predicate)
                    .FirstOrDefaultAsync();
        }
    }
}
