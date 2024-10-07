using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Abstractions.Repositories
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<T> Update(string id);
        Task Delete(int id);
        T Insert(T entity);
    }
}
