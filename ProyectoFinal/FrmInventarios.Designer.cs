namespace ProyectoFinal
{
    partial class FrmInventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventarios));
            this.dgvInventarios = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblApellidoMatern = new System.Windows.Forms.Label();
            this.txtProovedor = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNomb = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCajas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventarios
            // 
            this.dgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarios.Location = new System.Drawing.Point(8, 5);
            this.dgvInventarios.Name = "dgvInventarios";
            this.dgvInventarios.RowTemplate.Height = 25;
            this.dgvInventarios.Size = new System.Drawing.Size(659, 579);
            this.dgvInventarios.TabIndex = 2;
            this.dgvInventarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventarios_CellContentClick);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(705, 159);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(208, 23);
            this.txtPrecio.TabIndex = 21;
            // 
            // lblApellidoMatern
            // 
            this.lblApellidoMatern.AutoSize = true;
            this.lblApellidoMatern.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoMatern.Location = new System.Drawing.Point(705, 133);
            this.lblApellidoMatern.Name = "lblApellidoMatern";
            this.lblApellidoMatern.Size = new System.Drawing.Size(40, 15);
            this.lblApellidoMatern.TabIndex = 20;
            this.lblApellidoMatern.Text = "Precio";
            // 
            // txtProovedor
            // 
            this.txtProovedor.Location = new System.Drawing.Point(705, 98);
            this.txtProovedor.Name = "txtProovedor";
            this.txtProovedor.Size = new System.Drawing.Size(208, 23);
            this.txtProovedor.TabIndex = 19;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoP.Location = new System.Drawing.Point(705, 74);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(62, 15);
            this.lblApellidoP.TabIndex = 18;
            this.lblApellidoP.Text = "Proovedor";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(705, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 17;
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomb.Location = new System.Drawing.Point(705, 9);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(51, 15);
            this.lblNomb.TabIndex = 16;
            this.lblNomb.Text = "Nombre";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(718, 540);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(208, 23);
            this.btnRegresar.TabIndex = 33;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(718, 509);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(208, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(718, 480);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(208, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(718, 451);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(208, 23);
            this.btnRegistro.TabIndex = 30;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(705, 220);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(208, 23);
            this.txtPeso.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(705, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Peso_Kg";
            // 
            // txtCajas
            // 
            this.txtCajas.Location = new System.Drawing.Point(705, 286);
            this.txtCajas.Name = "txtCajas";
            this.txtCajas.Size = new System.Drawing.Size(208, 23);
            this.txtCajas.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(705, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cajas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(952, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCajas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblApellidoMatern);
            this.Controls.Add(this.txtProovedor);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNomb);
            this.Controls.Add(this.dgvInventarios);
            this.Name = "FrmInventarios";
            this.Text = "FrmInventarios";
            this.Load += new System.EventHandler(this.FrmInventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvInventarios;
        private TextBox txtPrecio;
        private Label lblApellidoMatern;
        private TextBox txtProovedor;
        private Label lblApellidoP;
        private TextBox txtNombre;
        private Label lblNomb;
        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnRegistro;
        private TextBox txtPeso;
        private Label label1;
        private TextBox txtCajas;
        private Label label2;
        private PictureBox pictureBox1;
    }
}