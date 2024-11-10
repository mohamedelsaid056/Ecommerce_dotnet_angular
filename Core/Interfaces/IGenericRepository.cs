using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.models;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity, int id);
        Task DeleteAsync(int id);
    }
}