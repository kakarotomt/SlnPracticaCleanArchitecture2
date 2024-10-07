using Agena.Domain.Abstracts.Repository;
using Agena.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infraestructure.Repositories
{
    public sealed class TelefonoRepository : BaseRepository<Telefono>, ITelefonoRespository
    {
        private readonly ApplicationContext _context;

        public TelefonoRepository(ApplicationContext context) : base(context) 
        {
            _context = context;
        }
    }
}
