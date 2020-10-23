using System.Collections.Generic;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Interfaces
{
    public interface IDatabaseFirebase<T>
    {

        string EntityName { get; set; }
        Task<List<T>> GetAsync();
        Task Insert(T Entity);
        Task Update(T Entity);
        Task Delete(T Entity);


    }
}
