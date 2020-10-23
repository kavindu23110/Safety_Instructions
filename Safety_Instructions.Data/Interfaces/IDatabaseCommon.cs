using System.Collections.Generic;

namespace Safety_app.Data.Interfaces

{
    public interface IDatabaseCommon<T>
    {
        string EntityName { get; set; }
        List<T> GetAsync();
        void Insert(T Entity);

    }
}
