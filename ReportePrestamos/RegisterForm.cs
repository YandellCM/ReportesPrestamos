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

        
            private void btnAmortizacion_Click(object sender, EventArgs e)
            {
                Amortizacion formAmortizacion = new Amortizacion();
                formAmortizacion.Show(); // Muestra el formulario de amortización
            }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            RegistPrestCliente formularioPrestamo = new RegistPrestCliente(); // Crear instancia del formulario
            formularioPrestamo.ShowDialog(); // Mostrar el formulario de manera modal
        }

    }
}
