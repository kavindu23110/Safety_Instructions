using Safety_app.Data.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Safety_app.Data.DatabaseOperation
{
    public abstract class DatabaseOperation<T> : IDatabaseCommon<T> where T : class
    {
        public readonly SQLiteAsyncConnection _database;
        public DatabaseOperation(ref SQLiteAsyncConnection database)
        {
            _database = database;

        }

        public string EntityName { get ; set ; }

        public Task Delete(T Entity)
        {
            return _database.DeleteAsync(Entity);
        }

     
        public abstract Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);

        public abstract Task<List<T>> GetAsync();
        public abstract Task<T> GetSelectedAsync(Expression<Func<T, bool>> predicate);

        public Task Insert(T Entity)
        {
            return _database.InsertAsync(Entity);
        }

        public Task Update(T Entity)
        {
            return _database.UpdateAsync(Entity);
        }

     




    }
}
