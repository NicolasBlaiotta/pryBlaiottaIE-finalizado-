using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using pryBlaiottaIE;
using pryBlaiottaIE.Clases;

namespace pryBlaiottaIE
{

    public partial class frmBD : Form
    {
    crud Crud = new crud();

        public frmBD()
        {
            InitializeComponent();
            Crud.mostrar(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            GrillaBD GrillaBD = new GrillaBD();
            GrillaBD.Show();
            this.Hide();
        }
    }


}
