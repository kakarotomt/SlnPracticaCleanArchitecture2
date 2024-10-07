using Agena.Domain.Abstracts;

namespace Agena.Domain.Entities
{
    public sealed class Persona : Entity
    {
        public Persona() { }


        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public IEnumerable<Telefono> Telefonos { get; set; }

    }
}
