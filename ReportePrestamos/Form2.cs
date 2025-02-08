using System;
using System.Windows.Forms;

namespace ReportePrestamos
{
    public partial class Form2 : Form
    {
        private string tipoUsuario;

        public Form2(string tipoUsuario) // Recibe si es "Admin" o "Cliente"
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            if (tipoUsuario == "Cliente")
            {
                // 🔹 Ocultar o deshabilitar funciones exclusivas de admin
                btnRegistrar.Visible = false; // Ocultar botón de registro si solo los admins pueden usarlo
                // Agrega más restricciones aquí si es necesario
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
