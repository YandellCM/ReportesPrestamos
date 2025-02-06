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

                MiGaleria.DatosRegistro datosRegistro = new MiGaleria.DatosRegistro
                {
                    Nombre = txtNombreCliente.Text,
                    Apellido = txtApellidoCliente.Text,
                    Telefono = decimal.Parse(txtTelefonoCliente.Text),
                    Direccion = txtDireccionCliente.Text,
                    IngresoMensual = decimal.Parse(txtIngresosCliente.Text),
                    CantidadMoras = decimal.Parse(txtCantidadMorasCliente.Text),
                };
                /*
                //Datos propietario
                Prestamos prestamos = new Prestamos
                {
                    MontoPrestamo = txt.Text,
                    Nombre = txtPropietarioNombre.Text,
                    Calle = txtPropietarioCalle.Text,
                    Ciudad = txtPropietarioCiudad.Text,
                    Estado = txtPropietarioEstado.Text,
                    CP = decimal.Parse(txtPropietarioCP.Text),
                    CodigoDeArea = txtPropietarioRFC.Text,
                    Numero = decimal.Parse(txtPropietarioNumero.Text),
                    RFC = txtPropietarioRFC.Text
                };
                /*
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
                };*/

                ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
                conexion.Save(datosRegistro);

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
