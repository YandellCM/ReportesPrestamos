using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportePrestamos
{
    public partial class RegistPrestCliente : Form
    {
        public RegistPrestCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarPrestamoC_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtClientePrestamo.Text) ||
                string.IsNullOrEmpty(txtMontoPrestamo.Text) ||
                string.IsNullOrEmpty(txtMesesCliente.Text) ||
                string.IsNullOrEmpty(txtInteresCliente.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=AYC;Initial Catalog=PrestamosDB;Integrated Security=True;"))
                {
                    con.Open();

                    // Obtener el ID del cliente basado en el nombre ingresado
                    string queryCliente = "SELECT Id FROM Clientes WHERE Nombre = @Nombre";
                    int clienteId;

                    using (SqlCommand cmdCliente = new SqlCommand(queryCliente, con))
                    {
                        cmdCliente.Parameters.AddWithValue("@Nombre", txtClientePrestamo.Text);
                        object result = cmdCliente.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("El cliente no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        clienteId = Convert.ToInt32(result);
                    }

                    // Insertar el préstamo en la base de datos
                    string query = "INSERT INTO Prestamos (ClienteId, Monto, PlazoMeses, TasaInteres) VALUES (@ClienteId, @Monto, @PlazoMeses, @TasaInteres)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                        cmd.Parameters.AddWithValue("@Monto", Convert.ToDecimal(txtMontoPrestamo.Text));
                        cmd.Parameters.AddWithValue("@PlazoMeses", Convert.ToInt32(txtMesesCliente.Text));
                        cmd.Parameters.AddWithValue("@TasaInteres", Convert.ToDecimal(txtInteresCliente.Text));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después del registro
                    txtClientePrestamo.Clear();
                    txtMontoPrestamo.Clear();
                    txtMesesCliente.Clear();
                    txtInteresCliente.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
