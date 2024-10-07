using Dominio.Abstractions.Repositories;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public sealed class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AgendaRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
