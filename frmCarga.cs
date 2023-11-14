using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBlaiottaIE
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(6);
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                frmPrincipal frmPrincipal = new frmPrincipal();
                this.Hide();
                frmPrincipal.Show();
            }
        }
    }
}
