using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Interfaces
{
    public interface IDatabase<T>
    {
        FirebaseClient firebase { get; set; }
        string EntityName { get; set; }
        Task<List<T>> GetAsync();
        Task Insert(T Entity);
        Task Update(T Entity);
        Task Delete(T Entity);

        Task<T> Findasync(Func<T, bool> predicate);
    }
}
