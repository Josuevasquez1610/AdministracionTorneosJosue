using AdminitracionDeTorneosP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.Database
{
    class HORARIODB
    {
        string connectionString = "Server=LAPTOP-0A8H41G8;Database=PROYECTO_TORNEOS;User Id = capacitation; Password=manager;";

        public void verHorarios(DataGridView list)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM HORARIO_EMPRESA";
                    SqlDataAdapter sqll = new SqlDataAdapter(query, connection);

                    connection.Open();

                    DataTable data = new DataTable();
                    sqll.Fill(data);
                    list.DataSource = data;

                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }


        public Horario buscarHorario(string dia)
        {
            Horario horario = new Horario();
            string query = "SELECT * FROM HORARIO_EMPRESA WHERE Dia = @Dia";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Dia", dia);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    horario.Apertura = TimeSpan.FromHours(1);
                    horario.Cierre = TimeSpan.FromHours(2);

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                return horario;
            }
        }

        public void agregarHorario(Horario horario)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HORARIO_EMPRESA(Dia,Apertura,Cierre)VALUES(@Dia,@Apertura,@Cierre)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Dia", horario.Dia);
                command.Parameters.AddWithValue("@Apertura", horario.Apertura);
                command.Parameters.AddWithValue("@Cierre", horario.Cierre);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Horario Agregado");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        public void actualizarHorario(Horario horario)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE HORARIO_EMPRESA SET Apertura = @Apertura, Cierre = @Cierre  WHERE Dia = @Dia;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Dia", horario.Dia);
                command.Parameters.AddWithValue("@Apertura", horario.Apertura);
                command.Parameters.AddWithValue("@Cierre", horario.Cierre);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Horario Actualizado");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        public void eliminarHorario(string dia)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM HORARIO_EMPRESA WHERE Dia = @Dia";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Dia", dia);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Horario eliminado");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }
    }
}
