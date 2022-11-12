using System;
using System.Collections.Generic;

namespace Aduanas.Models
{
    public partial class Empleado
    {
        public int? IdPersona { get; set; }
        public int? IdAgencia { get; set; }
        public int? IdRol { get; set; }
        public string Usuario { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int IdEmpleado { get; set; }

        public virtual Agencia? IdAgenciaNavigation { get; set; }
        public virtual Persona? IdPersonaNavigation { get; set; }
        public virtual Role? IdRolNavigation { get; set; }
    }
}
