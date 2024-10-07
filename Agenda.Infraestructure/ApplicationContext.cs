using Agena.Domain.Abstracts;
using Agena.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infraestructure
{
    public sealed class ApplicationContext : DbContext, IUnitOfWork
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        DbSet<Persona> Personas { get; set; }
        DbSet<Telefono> Telefonos { get; set; }
    }
}
