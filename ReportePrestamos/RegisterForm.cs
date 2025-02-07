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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
            RegistroClienteAD f = new RegistroClienteAD();
            f.Show();

            this.Hide();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            RegistPrestCliente f = new RegistPrestCliente();
            f.Show();

            this.Hide();
        }

        private void btnAmortizacion_Click(object sender, EventArgs e)
        {
            Amortizacion f = new Amortizacion();
            f.Show();

            this.Hide();
        }
    }
}
