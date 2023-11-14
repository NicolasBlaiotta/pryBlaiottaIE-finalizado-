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
    public partial class frmInicio : Form
    {
        crud Crud = new crud();
        public frmInicio()
        {
            Crud.Conectar();
            InitializeComponent();
            lblConexion.Text=Crud.estadoconexion;
        }
        int contador = 0;
        string usuario = "admin";
        string contraseña = "123";
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            control();
            if(contador==3)
            {
                MessageBox.Show("Limite de intentos alcanzado ");
                this.Close();
            }

        }
        public void control()
        {
            if(textBox1.Text==usuario && textBox2.Text==contraseña)  
            {
                frmCarga frmCarga = new frmCarga();
                frmCarga.Show();
                this.Hide();

            }
            else 
            {
                contador++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNavegar frmNavegar = new frmNavegar();
            frmNavegar.Show();
            this.Hide();
        }

        private void lblConeccion_Click(object sender, EventArgs e)
        {

        }
    }
}
