using System.Collections.Generic;
using System.Threading.Tasks;

namespace Safety_app.Data.Interfaces

{
    public interface IDatabasesqlite<T>
    {
        Task<List<T>> GetAsync();
        Task<int> saveAsync(T Entity);
        Task<int> DeleteAsync(T Entity);
    }
}
