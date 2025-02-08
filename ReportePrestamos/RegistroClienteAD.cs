using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReportePrestamos
{
    public partial class RegistroClienteAD : Form
    {
        private string connectionString = "Server=localhost; database=PrestamoDB; Integrated Security=True";

        public RegistroClienteAD()
        {
            InitializeComponent();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            // Recogemos los datos del formulario
            string ID = txtIdClienteAD.Text.Trim();
            string nombre = txtNombreClienteAD.Text.Trim();
            string apellido = txtApellidoClienteAD.Text.Trim();
            string telefono = txtTelefonoClienteAD.Text.Trim();
            string direccion = txtDireccionClienteAD.Text.Trim();
            string ingresoMensual = txtIngresosClienteAD.Text.Trim();

            // Validación básica para asegurarse de que los campos no están vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(ingresoMensual))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Conectamos a la base de datos
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    // Sentencia SQL para actualizar los datos
                    string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion, IngresoMensual = @IngresoMensual WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        // Asignamos los parámetros
                        command.Parameters.AddWithValue("@Id", ID);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@IngresoMensual", ingresoMensual);

                        // Ejecutamos el comando y verificamos cuántas filas se han actualizado
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente actualizado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún cliente con ese Id.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
            }
        }

        private void txtApellidoClienteAD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
