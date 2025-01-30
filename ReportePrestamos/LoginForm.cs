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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarLogin(string correo)
        {
            bool esValido = false;
            string connectionString = "Data Source=AYC;Initial Catalog=PrestamosDB;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Admin WHERE Email = @Correo";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            return esValido;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string correo = txtUsuario.Text.Trim();

            if (ValidarLogin(correo))
            {
                MessageBox.Show("Acceso concedido. Bienvenido al sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 principal = new Form2();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Correo incorrecto o usuario no registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
