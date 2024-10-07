using Dominio.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public sealed class Agenda : Entity
    {
        public Agenda()
        {
            
        }

        public string Name { get; set; }
        public string Number { get; set; }
    }
}
