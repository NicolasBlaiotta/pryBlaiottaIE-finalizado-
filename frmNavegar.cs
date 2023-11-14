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
using pryBlaiottaIE.clases;

namespace pryBlaiottaIE
{

    public partial class frmNavegar : Form
    {
        ABM ABM = new ABM();
        public frmNavegar()
        {
            InitializeComponent();
        }

        private frmPrincipal formularioGrilla;
        public frmNavegar (frmPrincipal grillaForm) // hacer publicos los datos para la grilla
        {
            InitializeComponent();
            formularioGrilla = grillaForm;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNavegar_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidador.Clear();
            MessageBox.Show("Los datos se han borrado correctamente.");
        }

        private void lblLiquidador_Click(object sender, EventArgs e)
        {

        }

        private void txtLiquidador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string textoIngresado = txtNumero.Text;
            string textoIngresado1 = txtEntidad.Text;
            string textoIngresado2 = txtApertura.Text;
            string textoIngresado3 = txtNExpediente.Text;
            string textoIngresado4 = txtJuzgado.Text;
            string textoIngresado5 = txtDireccion.Text;
            string textoIngresado6 = txtLiquidador.Text;
            string textoIngresado7 = txtJurisdiccion.Text;
            MessageBox.Show("Los datos se han guardado correctamente.");

            //mostrar en grilla 
          
            DataGridViewRow fila = new DataGridViewRow();
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = textoIngresado });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = textoIngresado2 });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = textoIngresado3 });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = textoIngresado4 });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = textoIngresado5 });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = textoIngresado6 });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = textoIngresado7 });












        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
                ABM.insertar(txtEntidad, txtApertura, txtNumero, txtJuzgado, txtDireccion, txtLiquidador);
                ABM.mostrar(dataGridView1);
            
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            frmBD frmBD = new frmBD();
            frmBD.Show();
            this.Hide();
        }
    }
}
