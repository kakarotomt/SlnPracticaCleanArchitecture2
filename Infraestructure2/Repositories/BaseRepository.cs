using Dominio2.Abtractions;
using Dominio2.Abtractions.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure2.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T entity, CancellationToken cancellationToken)
        {
            _context.Add(entity);
        }

        public void Delete(int id, CancellationToken cancellationToken)
        {
            var entity = _context.Set<T>().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
            }
        }

        public Task<List<T>> Get(CancellationToken cancellationToken)
        {
            return _context.Set<T>().ToListAsync();
        }

        public Task<T> Get(int Id, CancellationToken cancellationToken)
        {
            return _context.Set<T>().FirstOrDefaultAsync(m =>m.Id == Id) ?? null;
        }

        public T Update(T entity, CancellationToken cancellationToken)
        {
            _context.Update(entity);
            return entity;
        }
    }
}
