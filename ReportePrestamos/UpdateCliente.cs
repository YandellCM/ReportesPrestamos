using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReportePrestamos
{
    public partial class UpdateCliente : Form
    {
        public UpdateCliente()
        {
            InitializeComponent();
        }

        private void btnActualizarPrestamo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoDelPrestamo.Text) ||
                string.IsNullOrEmpty(txtPlazoDelPrestamo.Text) ||
                string.IsNullOrEmpty(txtTasaDeInteres.Text) ||
                string.IsNullOrEmpty(txtEstadoDelPrestamo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=AYC;Initial Catalog=PrestamosDB;Integrated Security=True;"))
                {
                    con.Open();
                    string query = "UPDATE Prestamos SET Monto = @Monto, PlazoMeses = @Plazo, TasaInteres = @Tasa, Estado = @Estado WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Monto", Convert.ToDecimal(txtMontoDelPrestamo.Text));
                        cmd.Parameters.AddWithValue("@Plazo", Convert.ToInt32(txtPlazoDelPrestamo.Text));
                        cmd.Parameters.AddWithValue("@Tasa", Convert.ToDecimal(txtTasaDeInteres.Text));
                        cmd.Parameters.AddWithValue("@Estado", txtEstadoDelPrestamo.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Préstamo actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un préstamo con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTasaDeInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
