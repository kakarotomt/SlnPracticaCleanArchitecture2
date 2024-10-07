using Dominio2.Abtractions.Repositories;
using Dominio2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure2.Repositories
{
    public sealed class RegistroRepository: BaseRepository<Registro>, IRegistroRepository
    {
        private readonly ApplicationDbContext _context;

        public RegistroRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
