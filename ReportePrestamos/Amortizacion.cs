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
    public partial class Amortizacion : Form
    {
        public Amortizacion()
        {
            InitializeComponent();
        }

        private void btnRegistrarAmortizacion_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNumPago.Text) ||
                string.IsNullOrWhiteSpace(txtFechaPago.Text) ||
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
            txtFechaPago.Clear();
            txtPagoTotal.Clear();
            txtIntereses.Clear();
            txtAmortizacion.Clear();
            txtSaldo.Clear();
            txtTasaInteres.Clear();
            txtTipoAmortizacion.Clear();
        }

    }
}
