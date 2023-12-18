using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;

namespace pryBlaiottaIE.Clases
{
    internal class crud
    {
        OleDbCommand comando;
        OleDbDataReader reader;
        OleDbConnection conexionBD;
        //proporciona un conjunto de comandos de base de datos y una conexión de base de datos
        OleDbDataAdapter adapter;
        string cadenaconexion = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Data Source=EL_CLUB1.accdb";
        public string estadoconexion = "";


        public void Conectar()
        {
            try
            {

                conexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = EL_CLUB1.accdb");
                conexionBD.Open();
                estadoconexion = "conectado";
            }
            catch (Exception ex)
            {
                estadoconexion = "Error " + ex.ToString();

            }

        }
        public void mostrar(DataGridView TablaSocios)
        {
            // obtengo la cadena de conexión a la base de datos desde la configuración del programa
            var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
            try
            {
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    //abre la conexion a la bd
                    conector.Open();
                    //selecciono que quiero que sea desde la tabla socios
                    string query = @"select * from Socios";
                    DataTable DT = new DataTable();
                    comando = new OleDbCommand(query, conector);
                    adapter = new OleDbDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    adapter.Fill(DT);
                    TablaSocios.DataSource = DT;


                }

            }
            catch (Exception ex)
            {
                estadoconexion = "Error " + ex;
            }

        }
        public void Buscar(TextBox id, TextBox apellido, DataGridView data)
        {
            var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
            try
            {
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    conector.Open();
                    string query = @"select * from Socios where id=@id and apellido=@apellido";
                    DataTable DT = new DataTable();
                    comando = new OleDbCommand(query, conector);
                    comando.Parameters.AddWithValue("@id", id.Text);
                    comando.Parameters.AddWithValue("@apellido", apellido.Text);
                    adapter = new OleDbDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    adapter.Fill(DT);
                    data.DataSource = DT;

                }

            }
            catch (Exception ex)
            {
                estadoconexion = "Error " + ex;
            }

        }
        public void actualizar(TextBox id, TextBox apellido, TextBox estado)
        {
            var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
            try
            {
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    conector.Open();
                    string query = @"update SOCIOS set LUGAR_NACIMIENTO=@LUGAR where id =@id or apellido=@apellido";
                    comando = new OleDbCommand(query, conector);
                    comando.Parameters.AddWithValue("@id", id.Text);
                    comando.Parameters.AddWithValue("@apellido", apellido.Text);
                    comando.Parameters.AddWithValue("@LUGAR", estado.Text);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Actualizado");
                    }
                }

            }
            catch (Exception ex)
            {
                estadoconexion = "Error " + ex.ToString();
            }
        }

    }
}