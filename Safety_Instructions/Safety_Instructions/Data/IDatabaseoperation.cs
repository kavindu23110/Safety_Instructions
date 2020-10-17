﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Safety_Instructions.Data
{
    public interface IDatabaseoperation<T>
    {
        Task<List<T>> GetAsync();
        Task<int> saveAsync(T Entity);
        Task<int> DeleteAsync(T Entity);
    }
}
