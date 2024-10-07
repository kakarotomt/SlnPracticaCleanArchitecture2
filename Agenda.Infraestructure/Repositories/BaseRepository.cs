using Agena.Domain.Abstracts;
using Agena.Domain.Abstracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infraestructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {

        private readonly ApplicationContext _applicationContext;

        protected BaseRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public T CreateAsync(T entity, CancellationToken cancellationToken)
        {
            _applicationContext.Add(entity);
            return entity;
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> SelectAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T?> SelectAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
