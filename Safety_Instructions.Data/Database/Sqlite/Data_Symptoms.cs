using Safety_Instructions.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Database.Sqlite
{
    public class Data_Symptoms : Safety_app.Data.DatabaseOperation.DatabaseOperation<Symptoms>
    {
        public Data_Symptoms(ref SQLiteAsyncConnection database) : base(ref database)
        {
            _database.CreateTableAsync<Symptoms>().Wait();
        }
        public override Task<List<Symptoms>> FindAsync(Expression<Func<Symptoms, bool>> predicate)
        {
            return _database.Table<Symptoms>()
                       .Where(predicate)
                       .ToListAsync();
        }

        public override Task<List<Symptoms>> GetAsync()
        {
            return _database.Table<Symptoms>().ToListAsync();
        }

        public override Task<Symptoms> GetSelectedAsync(Expression<Func<Symptoms, bool>> predicate)
        {
            return _database.Table<Symptoms>().FirstOrDefaultAsync();
        }


    }
}
