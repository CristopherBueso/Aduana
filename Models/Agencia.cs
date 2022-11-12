using System;
using System.Collections.Generic;

namespace Aduanas.Models
{
    public partial class Agencia
    {
        public Agencia()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdAgencia { get; set; }
        public string NombreAgencia { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Pais { get; set; } = null!;

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
