using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReportePrestamos
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string ValidarLogin(string nombre, string contrasena)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=PrestamoDB;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 🔹 Verificar si el usuario es ADMIN
                string queryAdmin = "SELECT 'Admin' FROM Admin WHERE Nombre=@Nombre AND Contraseña=@Contrasena";
                using (SqlCommand cmd = new SqlCommand(queryAdmin, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return "Admin"; // Es administrador
                    }
                }

                // 🔹 Verificar si el usuario es CLIENTE
                string queryCliente = "SELECT 'Cliente' FROM Clientes WHERE Nombre=@Nombre AND Contraseña=@Contrasena";
                using (SqlCommand cmd = new SqlCommand(queryCliente, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return "Cliente"; // Es cliente
                    }
                }
            }

            return "Invalido"; // Usuario o contraseña incorrectos
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoUsuario = ValidarLogin(nombre, contrasena);

            if (tipoUsuario == "Admin")
            {
                MessageBox.Show("Acceso concedido como Administrador.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 principal = new Form2("Admin");
                principal.Show();
            }
            else if (tipoUsuario == "Cliente")
            {
                MessageBox.Show("Acceso concedido como Cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 principal = new Form2("Cliente");
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroClientes registroClientes = new RegistroClientes();
            registroClientes.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e) { }
        private void txtContrasena_TextChanged(object sender, EventArgs e) { }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
