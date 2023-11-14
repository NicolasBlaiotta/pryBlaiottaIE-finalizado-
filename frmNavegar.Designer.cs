namespace pryBlaiottaIE
{
    partial class frmNavegar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNExpediente = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.txtJuzgado = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAvanzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(29, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Location = new System.Drawing.Point(29, 274);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(116, 13);
            this.lblLiquidador.TabIndex = 1;
            this.lblLiquidador.Text = "Liquidador responsable";
            this.lblLiquidador.Click += new System.EventHandler(this.lblLiquidador_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(31, 239);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Location = new System.Drawing.Point(31, 204);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(62, 13);
            this.lblJurisdiccion.TabIndex = 3;
            this.lblJurisdiccion.Text = "Jurisdiccion";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(29, 64);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(43, 13);
            this.lblEntidad.TabIndex = 4;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblNExpediente
            // 
            this.lblNExpediente.AutoSize = true;
            this.lblNExpediente.Location = new System.Drawing.Point(29, 134);
            this.lblNExpediente.Name = "lblNExpediente";
            this.lblNExpediente.Size = new System.Drawing.Size(89, 13);
            this.lblNExpediente.TabIndex = 5;
            this.lblNExpediente.Text = "N° de expediente";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(31, 99);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(47, 13);
            this.lblApertura.TabIndex = 6;
            this.lblApertura.Text = "Apertura";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(163, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(163, 97);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(100, 20);
            this.txtApertura.TabIndex = 8;
            // 
            // txtLiquidador
            // 
            this.txtLiquidador.Location = new System.Drawing.Point(163, 267);
            this.txtLiquidador.Name = "txtLiquidador";
            this.txtLiquidador.Size = new System.Drawing.Size(100, 20);
            this.txtLiquidador.TabIndex = 9;
            this.txtLiquidador.TextChanged += new System.EventHandler(this.txtLiquidador_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(163, 233);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(163, 63);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntidad.TabIndex = 11;
            // 
            // txtNExpediente
            // 
            this.txtNExpediente.Location = new System.Drawing.Point(163, 131);
            this.txtNExpediente.Name = "txtNExpediente";
            this.txtNExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtNExpediente.TabIndex = 12;
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(163, 199);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(100, 20);
            this.txtJurisdiccion.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(120, 314);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(215, 314);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Location = new System.Drawing.Point(32, 169);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(47, 13);
            this.lblJuzgado.TabIndex = 18;
            this.lblJuzgado.Text = "Juzgado";
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.Location = new System.Drawing.Point(163, 165);
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.Size = new System.Drawing.Size(100, 20);
            this.txtJuzgado.TabIndex = 19;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(120, 343);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.Text = "Mostrar";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 258);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(215, 343);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 22;
            this.btnAvanzar.Text = "Siguiente";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // frmNavegar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(665, 394);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtJuzgado);
            this.Controls.Add(this.lblJuzgado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtJurisdiccion);
            this.Controls.Add(this.txtNExpediente);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtLiquidador);
            this.Controls.Add(this.txtApertura);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblApertura);
            this.Controls.Add(this.lblNExpediente);
            this.Controls.Add(this.lblEntidad);
            this.Controls.Add(this.lblJurisdiccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblLiquidador);
            this.Controls.Add(this.lblNumero);
            this.Name = "frmNavegar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegar";
            this.Load += new System.EventHandler(this.frmNavegar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtLiquidador;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNExpediente;
        private System.Windows.Forms.TextBox txtJurisdiccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.TextBox txtJuzgado;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAvanzar;
    }
}