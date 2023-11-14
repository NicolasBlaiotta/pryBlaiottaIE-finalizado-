using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryBlaiottaIE;
using pryBlaiottaIE.Clases;

namespace pryBlaiottaIE
{
    public partial class GrillaBD : Form
    {
        crud Crud = new crud();
        public GrillaBD()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Crud.Buscar(textBox1, textBox2, dataGridView1);

        }
    }
}
