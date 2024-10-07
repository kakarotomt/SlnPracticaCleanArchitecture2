using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agena.Domain.Abstracts.Repository
{
    public interface IBaseRepository<T> where T : Entity
    {
        T CreateAsync(T entity, CancellationToken cancellationToken);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
        Task<List<T>> SelectAsync(CancellationToken cancellationToken);
        Task<T?> SelectAsync(int id,CancellationToken cancellationToken);
    }
}
