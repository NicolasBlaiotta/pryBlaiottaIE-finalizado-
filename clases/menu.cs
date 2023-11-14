using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;


namespace pryBlaiottaIE.Clases
{
    public class menu

    {
        OleDbCommand comando;
        OleDbDataReader reader;
        OleDbConnection conexionBD;
        OleDbDataAdapter adapter;
        string cadenaconexion = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\Users\\Nico\\Downloads\\EL_CLUB1.accdb";
        public string estadoconexion = "";

        public void insertar(TextBox fechahora, TextBox nombre, TextBox accion)
        {
            var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
            try
            {
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    //6b
                    conector.Open();
                    string query = @"insert into Tabla1(fechahora,nombre,accion )values(@fecha,@nombre,@accion);";
                    comando = new OleDbCommand(query, conector);
                    comando.Parameters.AddWithValue("@fecha", fechahora.Text);
                    comando.Parameters.AddWithValue("@nombre", nombre.Text);
                    comando.Parameters.AddWithValue("@accion", accion.Text);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se guardo en bitacora ");
                    }
                }




            }
            catch (Exception ex)
            {
                estadoconexion = "Error " + ex;
            }

        }
        public void mostrar_bitacora(DataGridView tablaBitacora)
        {
            try
            {
                var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    conector.Open();
                    string query = @"select * from Tabla1";
                    DataTable DT = new DataTable();
                    comando = new OleDbCommand(query, conector);
                    adapter = new OleDbDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    adapter.Fill(DT);
                    tablaBitacora.DataSource = DT;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }
        public void Registro_Usuarios(TextBox usuario, TextBox contraseña, string ingreso)
        {
            var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
            try
            {
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    //7
                    conector.Open();
                    string query = @"insert into Tabla1(usuario, contraseña )values(@nom,@cont);";
                    DataTable DT = new DataTable();
                    comando = new OleDbCommand(query, conector);
                    comando.Parameters.AddWithValue("@nom", usuario.Text);
                    comando.Parameters.AddWithValue("@cont", contraseña.Text);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se guardo en bitacora ");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }

    }
}