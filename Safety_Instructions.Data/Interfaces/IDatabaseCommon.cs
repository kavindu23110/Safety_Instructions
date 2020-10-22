using System.Collections.Generic;
using System.Threading.Tasks;

namespace Safety_app.Data.Interfaces

{
    public interface IDatabaseCommon<T>
    {
        string EntityName { get; set; }
        Task<List<T>> GetAsync();
        Task Insert(T Entity);
        Task Delete(T Entity);
        Task Update(T Entity);
    }
}
