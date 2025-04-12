using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Clase
{
    public class crud
    {
        string connectionString = "Server=LAPTOP-0I8HCQGL\\SQLEXPRESS;Database=tarea sql;Integrated Security=True; TrustServerCertificate=True; ";



        public string MostrarAlumno(string carnet)
        {
            string nombre = "No Existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    String query = $"SELECT * FROM Tb_alumnos where carnet = '{carnet}' ";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        nombre = reader["Estudiante"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return nombre;
        }


        public string AgregarAlumno(string carnet, string nombre, string email, string seccion)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Tb_alumnos (carnet, estudiante, seccion, email) VALUES (@carnet, @nombre, @seccion, @email)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@seccion", seccion);
                    command.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return "Resigtro Exitoso";
                }
                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
                
            }
        }
    }
}