using System;

namespace ReportePrestamos
{
    public class MiGaleria
    {
        public class DatosRegistro
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public decimal Telefono { get; set; }
            public string Direccion { get; set; }
            public decimal IngresoMensual { get; set; }
            public decimal CantidadMoras { get; set; }
            public string Contraseña { get; set; }
        }


    }

    public class Prestamos
    {
        public decimal MontoPrestamo { get; set; }
        public decimal Meses { get; set; }
        public decimal Interes { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public string EstadoPrestamo { get; set; }

    }
}
