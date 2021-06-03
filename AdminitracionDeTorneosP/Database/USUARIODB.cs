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
    class USUARIODB
    {
        string connectionstring = "Server=LAPTOP-0A8H41G8;Database=PROYECTO_TORNEOS;User Id = capacitation; Password=manager;";

        public List<Usuarios> verUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    string query = "SELECT * FROM USUARIOS";
                    SqlCommand sql = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuarios Usuario = new Usuarios();

                        Usuario.Id = reader.GetInt32(0);
                        Usuario.DPI = reader.GetString(1);
                        Usuario.Nombres = reader.GetString(2);
                        Usuario.Apellidos = reader.GetString(3);
                        Usuario.Usuario = reader.GetString(4);
                        Usuario.Clave = reader.GetString(5);
                        Usuario.Telefono = reader.GetString(6);
                        Usuario.Direccion = reader.GetString(7);
                        Usuario.Correo = reader.GetString(8);
                        Usuario.Puesto = reader.GetString(9);
                        Usuario.Rol = reader.GetString(10);
                        Usuario.Activo = reader.GetBoolean(11);
                        usuarios.Add(Usuario);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            return usuarios;
        }

        public Usuarios buscarUsuario(int id)
        {
            Usuarios usuarios = new Usuarios();

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    string query = "SELECT * FROM USUARIOS WHERE Id = @Id";

                    SqlCommand sql = new SqlCommand(query, connection);
                    sql.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();
                    usuarios.Id = reader.GetInt32(0);
                    usuarios.DPI = reader.GetString(1);
                    usuarios.Nombres = reader.GetString(2);
                    usuarios.Apellidos = reader.GetString(3);
                    usuarios.Usuario = reader.GetString(4);
                    usuarios.Clave = reader.GetString(5);
                    usuarios.Telefono = reader.GetString(6);
                    usuarios.Direccion = reader.GetString(7);
                    usuarios.Correo = reader.GetString(8);
                    usuarios.Puesto = reader.GetString(9);
                    usuarios.Rol = reader.GetString(10);
                    usuarios.Activo = reader.GetBoolean(11);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                return usuarios;
            }
        }

        public void agregarUsuario(Usuarios usuarios)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "INSERT INTO USUARIOS(DPI, Nombres, Apellidos, Usuario, Clave, Telefono, Direccion, Correo, Puesto, Rol) VALUES(@DPI, @Nombres, @Apellidos, @Usuario, @Clave, @Telefono, @Direccion, @Correo, @Puesto, @Rol)";
                try
                {
                    SqlCommand sql= new SqlCommand(query, connection);

                    sql.Parameters.AddWithValue("@DPI", usuarios.DPI);
                    sql.Parameters.AddWithValue("@Nombres", usuarios.Nombres);
                    sql.Parameters.AddWithValue("@Apellidos", usuarios.Apellidos);
                    sql.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                    sql.Parameters.AddWithValue("@Clave", usuarios.Clave);
                    sql.Parameters.AddWithValue("@Telefono", usuarios.Telefono);
                    sql.Parameters.AddWithValue("@Direccion", usuarios.Direccion);
                    sql.Parameters.AddWithValue("@Correo", usuarios.Correo);
                    sql.Parameters.AddWithValue("@Puesto", usuarios.Puesto);
                    sql.Parameters.AddWithValue("@Rol", usuarios.Rol);

                    connection.Open();

                    sql.ExecuteNonQuery();
                    MessageBox.Show("Usuario agregado");
                    
                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        public void actualizarUsuario(Usuarios usuario)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    string query = "UPDATE USUARIOS SET DPI = @DPI, Nombres = @Nombres,  Apellidos = @Apellidos,Usuario=@Usuario,Clave=@Clave, Telefono = @Telefono,Direccion=@Direccion, Correo = @Correo, Puesto=@Puesto,Rol = @Rol WHERE Id= @Id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", usuario.Id);
                    command.Parameters.AddWithValue("@DPI", usuario.DPI);
                    command.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                    command.Parameters.AddWithValue("@Clave", usuario.Clave);
                    command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    command.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                    command.Parameters.AddWithValue("@Correo", usuario.Correo);
                    command.Parameters.AddWithValue("@Puesto", usuario.Puesto);
                    command.Parameters.AddWithValue("@Rol", usuario.Rol);

                    connection.Open();

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Usuario actualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void desactivarUsuario (int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "UPDATE USUARIOS SET Activo = 0 WHERE Id = @Id;";
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametro al procedimiento
                command.Parameters.AddWithValue("@Id", Id);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Usuario desactivado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
