using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportePrestamos
{
    internal class MiGaleria
    {
        public class DatosRegistro
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public decimal Telefono { get; set; }
            public string Direccion { get; set; }
            public decimal Ingresos { get; set; }
            public decimal Moras { get; set; }

        }

        public class Prestamos
        {
            public decimal MontoPrestamo { get; set; }
            public decimal Meses {  get; set; }
            public decimal Interes {  get; set; }
            public DateTime FechaAprobacion { get; set; }
            public string EstadoPrestamo { get; set; }

        }


    }
}
