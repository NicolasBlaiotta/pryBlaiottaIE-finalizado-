using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryBlaiottaIE
{
    internal class Class1
    {
        OleDbConnection ConexionBaseDatos;

        public void ConexionBD()
        {
            ConexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=C: \\Users\\Alumno\\source\\repos\\pryBlaiottaIE1\\Resources");
            ConexionBaseDatos.Open();
        }
    }

}





