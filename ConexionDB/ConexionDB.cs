using System;
using MiGaleria;
using System.Data.SqlClient;
using ReportePrestamos;


namespace ConexionDB
{
    public class ConexionDB
    {
        private string connestr = "Server=localhost; database=PrestamoDB; Integrated Security=True";
        public void Save(MiGaleria.DatosRegistro datosRegistro, MiGaleria.Prestamos prestamos /*MiGaleria.Comprador comprador*/)
        {
            using (SqlConnection conexion = new SqlConnection(connestr))
            {
                conexion.Open();
                Console.WriteLine("Conexión establecida.");

                // Datos de la tabla Cliente
                string query = "INSERT INTO Clientes (Id, Nombre, Apellido, Telefono, Direccion, Ingresos, Moras) VALUES (@Id, @Nombre, @Apellido, @Telefono, @Direccion, @Ingresos, @Moras)";
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", datosRegistro.Id);
                    command.Parameters.AddWithValue("@Nombre", datosRegistro.Nombre);
                    command.Parameters.AddWithValue("@Apellido", datosRegistro.Apellido);
                    command.Parameters.AddWithValue("@Telefono", datosRegistro.Telefono);
                    command.Parameters.AddWithValue("@Direccion", datosRegistro.Direccion);
                    command.Parameters.AddWithValue("@Ingresos", datosRegistro.Ingresos);
                    command.Parameters.AddWithValue("@Moras", datosRegistro.Moras);

                    int filasAfectadas = command.ExecuteNonQuery();
                    Console.WriteLine(filasAfectadas + " fila(s) insertada(s).");
                }

                //Datos de la tabla Prestamos
                string queryPrestamos = "INSERT INTO Propietario (Apellido, Nombre, Calle, Ciudad, Estado, CP, CodigoDeArea, Numero, RFC) VALUES (@Apellido, @Nombre, @Calle, @Ciudad, @Estado, @CP, @CodigoDeArea, @Numero, @RFC)";
                using (SqlCommand commandPrestamos = new SqlCommand(queryPrestamos, conexion))
                {

                    commandPrestamos.Parameters.AddWithValue("@MontoPrestamo", prestamos.MontoPrestamo);
                    commandPrestamos.Parameters.AddWithValue("@Meses", prestamos.Meses);
                    commandPrestamos.Parameters.AddWithValue("@Interes", prestamos.Interes);
                    commandPrestamos.Parameters.AddWithValue("@FechaAprobacion", prestamos.FechaAprobacion);
                    commandPrestamos.Parameters.AddWithValue("@EstadoPrestamo", prestamos.EstadoPrestamo);


                    int filasAfectadas = commandPrestamos.ExecuteNonQuery();
                    Console.WriteLine(filasAfectadas + " fila(s) insertada(s).");

                }

                /*
                //Datos de la tabla Comprador
                string queryComprador = "INSERT INTO Comprador (Apellido, Nombre, Calle, Ciudad, Estado, CP_Comprador, CodigoDeArea_Comprador, Numero_Comprador) VALUES (@Apellido, @Nombre, @Calle, @Ciudad, @Estado, @CP_Comprador, @CodigoDeArea_Comprador, @Numero_Comprador)";
                using (SqlCommand commandComprador = new SqlCommand(queryComprador, conexion))
                {
                    commandComprador.Parameters.AddWithValue("@Apellido", comprador.Apellido);
                    commandComprador.Parameters.AddWithValue("@Nombre", comprador.Nombre);
                    commandComprador.Parameters.AddWithValue("@Calle", comprador.Calle);
                    commandComprador.Parameters.AddWithValue("@Ciudad", comprador.Ciudad);
                    commandComprador.Parameters.AddWithValue("@Estado", comprador.Estado);
                    commandComprador.Parameters.AddWithValue("@CP_Comprador", comprador.CP_Comprador);
                    commandComprador.Parameters.AddWithValue("@CodigoDeArea_Comprador", comprador.CodigoDeArea_Comprador);
                    commandComprador.Parameters.AddWithValue("@Numero_Comprador", comprador.Numero_Comprador);

                    int filasAfectadas = commandComprador.ExecuteNonQuery();
                    Console.WriteLine(filasAfectadas + " fila(s) insertada(s).");
                }
                */
            }
        }
    }
}
