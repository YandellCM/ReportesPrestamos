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

            string nombre = txtNombreCliente.Text.Trim();
            string apellido = txtApellidoCliente.Text.Trim();
            string telefono = txtTelefonoCliente.Text.Trim();
            string direccion = txtDireccionCliente.Text.Trim();
            string ingresoMensual = txtIngresosCliente.Text.Trim();
            string cantidadMoras = txtCantidadMorasCliente.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(ingresoMensual) || string.IsNullOrEmpty(cantidadMoras))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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



                ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
                conexion.Save(datosRegistro);

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)

            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

            LoginForm loginForm = new LoginForm();

            loginForm.Show();

            this.Hide();
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
