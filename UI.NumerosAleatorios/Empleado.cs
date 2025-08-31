using System;

namespace Empleado
{
    public class Empleado
    {
        public int Numero { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = string.Empty;
        public string Grupo { get; set; } = string.Empty;
        public decimal Sueldo { get; set; }
        public bool SeguroMedico { get; set; }
    }
}

