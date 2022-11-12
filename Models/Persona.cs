using System;
using System.Collections.Generic;

namespace Aduanas.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdPersona { get; set; }
        public int Identidad { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public string PaisOrigen { get; set; } = null!;
        public string? PaisNaturalizacion { get; set; }
        public string Telefono { get; set; } = null!;
        public string Correo { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
