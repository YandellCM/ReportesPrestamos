using System;
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
            txtInteresCliente.ReadOnly = true; // 🔹 Evitar que el usuario modifique
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas()) return;

            string nombreCliente = txtClientePrestamo.Text.Trim();
            decimal monto = Convert.ToDecimal(txtMontoPrestamo.Text);
            int meses = Convert.ToInt32(txtMesesCliente.Text);
            decimal ingresoMensual = ObtenerIngresoMensual(nombreCliente);

            if (!ValidarReglasNegocio(monto, ingresoMensual)) return;

            // 🔹 Calcular interés y monto total
            decimal tasaInteres = CalcularTasaInteres(meses);
            decimal interes = monto * tasaInteres * (meses / 12.0m);
            decimal montoTotal = monto + interes;

            // 🔹 Mostrar los valores calculados
            txtInteresCliente.Text = interes.ToString("N2");

            MessageBox.Show($"Cálculo realizado:\n\nTasa de Interés: {tasaInteres * 100}%\nInterés Generado: {interes:C}\nMonto Total: {montoTotal:C}",
                "Cálculo Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistrarPrestamoC_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas()) return;

            string nombreCliente = txtClientePrestamo.Text.Trim();
            decimal monto = Convert.ToDecimal(txtMontoPrestamo.Text);
            int meses = Convert.ToInt32(txtMesesCliente.Text);
            decimal tasaInteres = CalcularTasaInteres(meses);

            RegistrarPrestamo(nombreCliente, monto, meses, tasaInteres);
            MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarEntradas()
        {
            if (string.IsNullOrEmpty(txtClientePrestamo.Text) ||
                string.IsNullOrEmpty(txtMontoPrestamo.Text) ||
                string.IsNullOrEmpty(txtMesesCliente.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarReglasNegocio(decimal monto, decimal ingresoMensual)
        {
            if (ingresoMensual == 0)
            {
                MessageBox.Show("No se encontró el cliente en la base de datos. Verifique el nombre ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (monto > ingresoMensual * 4)
            {
                MessageBox.Show($"El préstamo no puede superar 4 veces el ingreso mensual.\nLímite permitido: {ingresoMensual * 4:C}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (monto > FONDO_MAXIMO)
            {
                MessageBox.Show("Fondos insuficientes para este préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private decimal ObtenerIngresoMensual(string nombreCliente)
        {
            decimal ingresoMensual = 0;
            string connectionString = "Data Source=localhost;Initial Catalog=PrestamoDB;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT IngresoMensual FROM Clientes WHERE LOWER(LTRIM(RTRIM(Nombre))) = LOWER(@Nombre)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombreCliente.Trim());
                    object result = cmd.ExecuteScalar();
                    if (result != null) ingresoMensual = Convert.ToDecimal(result);
                }
            }

            return ingresoMensual;
        }

        private decimal CalcularTasaInteres(int meses)
        {
            if (meses <= 3) return 0.10m;   // 10% anual
            if (meses <= 6) return 0.08m;   // 8% anual
            if (meses <= 12) return 0.07m;  // 7% anual
            return 0.05m;  // 5% anual si es más de 12 meses
        }

        private void RegistrarPrestamo(string nombreCliente, decimal monto, int meses, decimal tasaInteres)
        {
            using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=PrestamoDB;Integrated Security=True;"))
            {
                con.Open();
                string queryClienteId = "SELECT Id FROM Clientes WHERE LOWER(LTRIM(RTRIM(Nombre))) = LOWER(@Nombre)";
                int clienteId = 0;

                using (SqlCommand cmdCliente = new SqlCommand(queryClienteId, con))
                {
                    cmdCliente.Parameters.AddWithValue("@Nombre", nombreCliente.Trim());
                    object result = cmdCliente.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Error: El cliente no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    clienteId = Convert.ToInt32(result);
                }

                string query = "INSERT INTO Prestamos (ClienteId, Monto, PlazoMeses, TasaInteres, Estado) " +
                               "VALUES (@ClienteId, @Monto, @Meses, @TasaInteres, @Estado)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@Meses", meses);
                    cmd.Parameters.AddWithValue("@TasaInteres", tasaInteres);
                    cmd.Parameters.AddWithValue("@Estado", "Activo");  // Estado predeterminado
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
