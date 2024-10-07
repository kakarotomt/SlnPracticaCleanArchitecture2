using Dominio2.Abtractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio2.Entities
{
    public sealed class Registro : Entity
    {
        public string Nombre { get; set; }
        public string Apartamento { get; set; }
        public string Documento { get; set; }
    }
}
