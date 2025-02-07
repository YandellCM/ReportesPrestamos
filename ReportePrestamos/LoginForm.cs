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

        private bool ValidarLogin(string nombre, string contrasena)
        {
          

            string connectionString = "Data Source=AARONCS;Initial Catalog=PrestamoDB;Integrated Security=True;";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Cliente WHERE Nombre=@Nombre AND Contraseña=@Contrasena";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

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
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese su correo y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarLogin(nombre, contrasena))
            {
                MessageBox.Show("Acceso concedido. Bienvenido al sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 principal = new Form2();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos o usuario no registrado.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroClientes registroClientes = new RegistroClientes();

            registroClientes.Show();
            
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
