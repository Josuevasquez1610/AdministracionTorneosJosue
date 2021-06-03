using AdminitracionDeTorneosP.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.Database
{
    class CLIENTEDB
    {
        string connectionstring = "Server=LAPTOP-0A8H41G8;Database=PROYECTO_TORNEOS;User Id = capacitation; Password=manager;";

        public List<Cliente> verClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "SELECT * FROM CLIENTE";
                SqlCommand sql = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.Id = reader.GetInt32(0);
                        cliente.DPI = reader.GetString(1);
                        cliente.Nombres = reader.GetString(2);
                        cliente.Apellidos = reader.GetString(3);
                        cliente.Telefono = reader.GetString(4);
                        cliente.Correo = reader.GetString(5);
                        listaClientes.Add(cliente);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            return listaClientes;
        }

        public Cliente busarCliente(int id)
        {
            Cliente cliente = new Cliente();
            
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "SELECT * FROM CLIENTE WHERE Id = @Id";

                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Id", id);
                
                try
                {
                    connection.Open();
                    
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    cliente.Id = reader.GetInt32(0);
                    cliente.DPI = reader.GetString(1);
                    cliente.Nombres = reader.GetString(2);
                    cliente.Apellidos = reader.GetString(3);
                    cliente.Telefono = reader.GetString(4);
                    cliente.Correo = reader.GetString(5);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return cliente;
            }
        }

        public void agregarCliente(Cliente cliente)
        {
            string query = "INSERT INTO CLIENTE(DPI, Nombres, Apellidos, Telefono, Correo) VALUES(@DPI, @Nombres, @Apellidos, @Telefono, @Correo)";
            
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@DPI", cliente.DPI);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                try
                {
                    connection.Open();
                
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cliente agregado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void actualizarCliente(Cliente cliente)
        {
            string query = "UPDATE CLIENTE SET DPI = @DPI, Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono, Correo = @Correo WHERE Id = @Id";
            
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", cliente.Id);
                command.Parameters.AddWithValue("@DPI", cliente.DPI);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cliente actualizado");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        public void eliminarCliente(int id)
        {
            string query = "DELETE FROM CLIENTE WHERE Id = @Id;";
            
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);
                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cliente eliminado");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}
