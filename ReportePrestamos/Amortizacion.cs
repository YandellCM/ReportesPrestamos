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
    public partial class Amortizacion : Form
    {
        public Amortizacion()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=AARONCS;Initial Catalog=PrestamosDB;Integrated Security=True;";

        private void btnRegistrarAmortizacion_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNumPago.Text) ||
                string.IsNullOrWhiteSpace(dtpFechaPago.Text) ||
                string.IsNullOrWhiteSpace(txtPagoTotal.Text) ||
                string.IsNullOrWhiteSpace(txtIntereses.Text) ||
                string.IsNullOrWhiteSpace(txtAmortizacion.Text) ||
                string.IsNullOrWhiteSpace(txtSaldo.Text) ||
                string.IsNullOrWhiteSpace(txtTasaInteres.Text) ||
                string.IsNullOrWhiteSpace(txtTipoAmortizacion.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí puedes guardar los datos en una base de datos o lista
            MessageBox.Show("Amortización registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos después de registrar
            txtNumPago.Clear();
            dtpFechaPago.Value = dtpFechaPago.MinDate;
            txtPagoTotal.Clear();
            txtIntereses.Clear();
            txtAmortizacion.Clear();
            txtSaldo.Clear();
            txtTasaInteres.Clear();
            txtTipoAmortizacion.Clear();
        }

        private void btnRegistrarAmortizacionc_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtNumPago.Text) ||
                string.IsNullOrWhiteSpace(dtpFechaPago.Text) ||
                string.IsNullOrWhiteSpace(txtPagoTotal.Text) ||
                string.IsNullOrWhiteSpace(txtIntereses.Text) ||
                string.IsNullOrWhiteSpace(txtAmortizacion.Text) ||
                string.IsNullOrWhiteSpace(txtSaldo.Text) ||
                string.IsNullOrWhiteSpace(txtTasaInteres.Text) ||
                string.IsNullOrWhiteSpace(txtTipoAmortizacion.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Capturar datos
            int numeroPago;
            DateTime fechaPago;
            decimal pagoTotal, intereses, amortizacionCapital, saldoPendiente, tasaInteres;
            string tipoAmortizacion = txtTipoAmortizacion.Text;

            // Validar conversiones
            if (!int.TryParse(txtNumPago.Text, out numeroPago) ||
                !DateTime.TryParse(dtpFechaPago.Text, out fechaPago) ||
                !decimal.TryParse(txtPagoTotal.Text, out pagoTotal) ||
                !decimal.TryParse(txtIntereses.Text, out intereses) ||
                !decimal.TryParse(txtAmortizacion.Text, out amortizacionCapital) ||
                !decimal.TryParse(txtSaldo.Text, out saldoPendiente) ||
                !decimal.TryParse(txtTasaInteres.Text, out tasaInteres))
            {
                MessageBox.Show("Verifica que los valores ingresados sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // INSERTAR EN LA BASE DE DATOS (Sin incluir PrestamoId)
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Amortizacion (NumeroPago, FechaPago, PagoTotal, Intereses, AmortizacionCapital, SaldoPendiente, TasaInteres, TipoAmortizacion) " +
                                   "VALUES (@NumeroPago, @FechaPago, @PagoTotal, @Intereses, @AmortizacionCapital, @SaldoPendiente, @TasaInteres, @TipoAmortizacion)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NumeroPago", numeroPago);
                        command.Parameters.AddWithValue("@FechaPago", fechaPago);
                        command.Parameters.AddWithValue("@PagoTotal", pagoTotal);
                        command.Parameters.AddWithValue("@Intereses", intereses);
                        command.Parameters.AddWithValue("@AmortizacionCapital", amortizacionCapital);
                        command.Parameters.AddWithValue("@SaldoPendiente", saldoPendiente);
                        command.Parameters.AddWithValue("@TasaInteres", tasaInteres);
                        command.Parameters.AddWithValue("@TipoAmortizacion", tipoAmortizacion);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Amortización registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después del registro
                txtNumPago.Clear();
                dtpFechaPago.Value = dtpFechaPago.MinDate;
                txtPagoTotal.Clear();
                txtIntereses.Clear();
                txtAmortizacion.Clear();
                txtSaldo.Clear();
                txtTasaInteres.Clear();
                txtTipoAmortizacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la amortización: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amortizacion_Load(object sender, EventArgs e)
        {

        }

        private void txtIntereses_TextChanged(object sender, EventArgs e)
        {

        }
    }
}