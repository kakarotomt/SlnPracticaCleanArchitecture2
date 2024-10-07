using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio2.Abtractions.Repositories
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<List<T>> Get(CancellationToken cancellationToken);
        Task<T> Get(int Id,CancellationToken cancellationToken);
        T Update(T entity, CancellationToken cancellationToken);
        void Delete(int id,CancellationToken cancellationToken);
        void Add(T entity,CancellationToken cancellationToken);
    }
}
