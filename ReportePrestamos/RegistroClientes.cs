using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportePrestamos
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                /*MessageBox.Show($"NoFactura: {txtNoFactura.Text}    " +
                    $"Titulo: {txtArtistaApellido.Text}     " +
                    $"ArtistaApellido: {txtArtistaApellido.Text}    " +
                    $"ArtistaNombre: {txtArtistaNombre.Text}    " +
                    $"Precio: {txtPrecio.Text}    " +
                    $"Impuesto: {txtImpuesto.Text}    " +
                    $"Pago_Total: {txtPagoTotal.Text}    " +
                    $"FirmaVendedor: {txtFirmaVendedor.Text}    " +
                    $"Fecha: {dateTimePicker1.Text}    " +
                    $"Apellido: {txtPropietarioApellido.Text}    " +
                    $"Nombre: {txtPropietarioNombre.Text}    " +
                    $"Calle: {txtPropietarioCalle.Text}    " +
                    $"Ciudad: {txtPropietarioCiudad.Text}    " +
                    $"Estado: {txtPropietarioEstado.Text}    " +
                    $"CodigoPostal: {txtPropietarioCP.Text}    " +
                    $"CodigoArea: {txtPropietarioCodigoArea.Text}   " +
                    $"Numero: {txtPropietarioNumero.Text}    " +
                    $"RFC: {txtPropietarioRFC.Text}    " +
                    $"ApellidoComprador: {txtCompradorApellido.Text}    " +
                    $"NombreComprador; {txtCompradorNombre.Text}    " +
                    $"Calle: {txtCompradorCalle.Text}    " +
                    $"CiudadComprador: {txtCompradorCiudad.Text}    " +
                    $"EstadoComprador: {txtCompradorEstado.Text}    " +
                    $"CPComprador: {txtCompradorCP.Text}    " +
                    $"CodigoDeAreaComprador: {txtCompradorCodigoArea.Text}  " +
                    $"NumeroComprador: {txtCompradorNumero.Text}    ");*/

                //datos factura
                MiGaleria.DatosObra datosObra = new MiGaleria.DatosObra
                {
                    No_Factura = txtNoFactura.Text,
                    Titulo = txtTitulo.Text,
                    Artista_Apellido = txtArtistaApellido.Text,
                    Artista_Nombre = txtArtistaNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Impuesto = decimal.Parse(txtImpuesto.Text),
                    Pago_Total = decimal.Parse(txtPagoTotal.Text),
                    Firma_Vendedor = txtFirmaVendedor.Text,
                    Fecha = dateTimePicker1.Value
                };

                MessageBox.Show($"Nombre {txtArtistaNombre.Text} Apellido {txtArtistaApellido.Text}");
                //Datos propietario
                MiGaleria.Propietario propietario = new MiGaleria.Propietario
                {
                    Apellido = txtPropietarioApellido.Text,
                    Nombre = txtPropietarioNombre.Text,
                    Calle = txtPropietarioCalle.Text,
                    Ciudad = txtPropietarioCiudad.Text,
                    Estado = txtPropietarioEstado.Text,
                    CP = decimal.Parse(txtPropietarioCP.Text),
                    CodigoDeArea = txtPropietarioRFC.Text,
                    Numero = decimal.Parse(txtPropietarioNumero.Text),
                    RFC = txtPropietarioRFC.Text
                };

                //Datos Comprador
                MessageBox.Show($"CodigoComprador {txtCompradorCodigoArea.Text}");
                MiGaleria.Comprador comprador = new MiGaleria.Comprador
                {
                    Apellido = txtCompradorApellido.Text,
                    Nombre = txtCompradorNombre.Text,
                    Calle = txtCompradorCalle.Text,
                    Ciudad = txtCompradorCiudad.Text,
                    Estado = txtCompradorEstado.Text,
                    CP_Comprador = decimal.Parse(txtCompradorCP.Text),
                    CodigoDeArea_Comprador = txtCompradorCodigoArea.Text,
                    Numero_Comprador = decimal.Parse(txtCompradorNumero.Text)
                };

                ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
                conexion.Save(datosObra, propietario, comprador);

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
