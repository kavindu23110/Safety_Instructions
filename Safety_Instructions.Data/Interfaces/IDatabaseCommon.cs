using System.Collections.Generic;
using System.Threading.Tasks;

namespace Safety_app.Data.Interfaces

{
    public interface IDatabaseCommon<T>
    {
        string EntityName { get; set; }
        List<T> GetAsync();
        void Insert(T Entity);
  
    }
}
