using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReportePrestamos
{
    public partial class RegistPrestCliente : Form
    {
        private const decimal FONDO_MAXIMO = 5000000m;

        public RegistPrestCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarPrestamoC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientePrestamo.Text) ||
                string.IsNullOrEmpty(txtMontoPrestamo.Text) ||
                string.IsNullOrEmpty(txtMesesCliente.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal monto = Convert.ToDecimal(txtMontoPrestamo.Text);
                int meses = Convert.ToInt32(txtMesesCliente.Text);
                decimal sueldo = ObtenerSueldoCliente(txtClientePrestamo.Text);

                if (monto > sueldo * 4)
                {
                    MessageBox.Show("El préstamo no puede superar 4 veces el sueldo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (monto > FONDO_MAXIMO)
                {
                    MessageBox.Show("Fondos insuficientes para este préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal tasaInteres = CalcularTasaInteres(meses);
                decimal interes = monto * tasaInteres * (meses / 12.0m);
                decimal montoTotal = monto + interes;

                RegistrarPrestamo(txtClientePrestamo.Text, monto, meses, tasaInteres, montoTotal);

                MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ObtenerSueldoCliente(string nombreCliente)
        {
            using (SqlConnection con = new SqlConnection("Data Source=AYC;Initial Catalog=PrestamosDB;Integrated Security=True;"))
            {
                con.Open();
                string query = "SELECT Sueldo FROM Clientes WHERE Nombre = @Nombre";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombreCliente);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        private decimal CalcularTasaInteres(int meses)
        {
            if (meses <= 3) return 0.10m;
            if (meses <= 6) return 0.08m;
            if (meses <= 12) return 0.07m;
            return 0.05m;
        }

        private void RegistrarPrestamo(string nombreCliente, decimal monto, int meses, decimal tasaInteres, decimal montoTotal)
        {
            using (SqlConnection con = new SqlConnection("Data Source=AYC;Initial Catalog=PrestamosDB;Integrated Security=True;"))
            {
                con.Open();
                string query = "INSERT INTO Prestamos (ClienteId, Monto, PlazoMeses, TasaInteres, MontoTotal) VALUES ((SELECT Id FROM Clientes WHERE Nombre = @Nombre), @Monto, @Meses, @TasaInteres, @MontoTotal)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombreCliente);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@Meses", meses);
                    cmd.Parameters.AddWithValue("@TasaInteres", tasaInteres);
                    cmd.Parameters.AddWithValue("@MontoTotal", montoTotal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
