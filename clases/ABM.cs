using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBlaiottaIE.clases
{
    internal class ABM
    {
        OleDbCommand comando;
        OleDbDataReader reader;
        OleDbConnection conexionBD;
        OleDbDataAdapter adapter;
        string cadenaconexion = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=EL_CLUB1.accdb";
        public string estadoconexion = "";

        public void insertar(TextBox Entidad, TextBox Apertura, TextBox Numero, TextBox Juzgado, TextBox Direccion, TextBox Liquidador)
        {
            var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
            try
            {
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    conector.Open();
                    string query = @"insert into Tabla2(Entidad, Apertura, Numero_Expediente, Juzgado, Direccion, Liquidador )values(@Emtodad,@Apertura,@Numero,@Juzgado,@Direccion,@Liquidador);";
                    comando = new OleDbCommand(query, conector);
                    comando.Parameters.AddWithValue("@Entidad", Entidad.Text);
                    comando.Parameters.AddWithValue("@Apertura", Apertura.Text);
                    comando.Parameters.AddWithValue("@Numero", Numero.Text);
                    comando.Parameters.AddWithValue("@Juzgado", Juzgado.Text);
                    comando.Parameters.AddWithValue("@Direccion", Direccion.Text);
                    comando.Parameters.AddWithValue("@Liquidador", Liquidador.Text);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se guardo en registros ");
                    }

                }




            }
            catch (Exception ex)
            {
                estadoconexion = "Error " + ex;
            }

        }
        public void mostrar(DataGridView dgv)
        {
            try
            {
                var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
                using (OleDbConnection conector = new OleDbConnection(cadena))
                {
                    conector.Open();
                    string query = @"select * from Tabla2";
                    DataTable DT = new DataTable();
                    comando = new OleDbCommand(query, conector);
                    adapter = new OleDbDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    adapter.Fill(DT);
                    dgv.DataSource = DT;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }
    }

}
