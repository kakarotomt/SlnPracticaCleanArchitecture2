using Dominio2.Abtractions;
using Dominio2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure2
{
    public class ApplicationDbContext: DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions opt) : base(opt)
        {
            Database.EnsureCreated();
        }

        DbSet<Registro> Registros { get; set; }
    }
}
