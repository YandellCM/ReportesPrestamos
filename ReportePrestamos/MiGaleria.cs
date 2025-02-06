using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportePrestamos
{
    internal class MiGaleria
    {
        public class DatosObra
        {
            public string No_Factura { get; set; }
            public string Titulo { get; set; }
            public string Artista_Apellido { get; set; }
            public string Artista_Nombre { get; set; }
            public decimal Precio { get; set; }
            public decimal Impuesto { get; set; }
            public decimal Pago_Total { get; set; }
            public string Firma_Vendedor { get; set; }
            public DateTime Fecha { get; set; }
        }
    }
}
