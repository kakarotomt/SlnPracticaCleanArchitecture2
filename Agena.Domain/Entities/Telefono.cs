using Agena.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agena.Domain.Entities
{
    public sealed class Telefono : Entity
    {
        public string NumeroTelefono { get; set; }
        public string Pais { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

    }
}
