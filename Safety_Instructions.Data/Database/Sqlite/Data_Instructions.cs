using Safety_Instructions.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Database.Sqlite
{
    public class Data_Instructions : Safety_app.Data.DatabaseOperation.DatabaseOperation<Instruction>
    {
        public Data_Instructions(ref SQLiteAsyncConnection database) : base(ref database)
        {
            _database.CreateTableAsync<Instruction>().Wait();
        }
        public override Task<List<Instruction>> FindAsync(Expression<Func<Instruction, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public override Task<List<Instruction>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<Instruction> GetSelectedAsync(Expression<Func<Instruction, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
