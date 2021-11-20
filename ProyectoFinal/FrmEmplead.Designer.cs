namespace ProyectoFinal
{
    partial class FrmEmplead
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
            this.dgvEmplea = new System.Windows.Forms.DataGridView();
            this.lblNomb = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMatern = new System.Windows.Forms.Label();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.lblsexo = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplea)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmplea
            // 
            this.dgvEmplea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmplea.Location = new System.Drawing.Point(6, 5);
            this.dgvEmplea.Name = "dgvEmplea";
            this.dgvEmplea.RowTemplate.Height = 25;
            this.dgvEmplea.Size = new System.Drawing.Size(659, 579);
            this.dgvEmplea.TabIndex = 0;
            this.dgvEmplea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmplea_CellContentClick);
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomb.Location = new System.Drawing.Point(709, 26);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(51, 15);
            this.lblNomb.TabIndex = 1;
            this.lblNomb.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(709, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(709, 115);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(208, 23);
            this.txtApellidoPaterno.TabIndex = 4;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoP.Location = new System.Drawing.Point(709, 91);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(95, 15);
            this.lblApellidoP.TabIndex = 3;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(709, 183);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(208, 23);
            this.txtApellidoMaterno.TabIndex = 6;
            // 
            // lblApellidoMatern
            // 
            this.lblApellidoMatern.AutoSize = true;
            this.lblApellidoMatern.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoMatern.Location = new System.Drawing.Point(709, 157);
            this.lblApellidoMatern.Name = "lblApellidoMatern";
            this.lblApellidoMatern.Size = new System.Drawing.Size(99, 15);
            this.lblApellidoMatern.TabIndex = 5;
            this.lblApellidoMatern.Text = "Apellido Materno";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Checked = true;
            this.rbtnFemenino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFemenino.Location = new System.Drawing.Point(714, 250);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtnFemenino.TabIndex = 7;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsexo.Location = new System.Drawing.Point(709, 222);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(32, 15);
            this.lblsexo.TabIndex = 8;
            this.lblsexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnMasculino.Location = new System.Drawing.Point(828, 250);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbtnMasculino.TabIndex = 9;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(709, 313);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(208, 23);
            this.txtRfc.TabIndex = 11;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRFC.Location = new System.Drawing.Point(709, 287);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(28, 15);
            this.lblRFC.TabIndex = 10;
            this.lblRFC.Text = "RFC";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(709, 451);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(208, 23);
            this.btnRegistro.TabIndex = 12;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(709, 480);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(208, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(709, 509);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(208, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(709, 540);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(208, 23);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(714, 385);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 23);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbuscar.Location = new System.Drawing.Point(714, 359);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(42, 15);
            this.lblbuscar.TabIndex = 16;
            this.lblbuscar.Text = "Buscar";
            // 
            // FrmEmplead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(952, 588);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoMatern);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNomb);
            this.Controls.Add(this.dgvEmplea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEmplead";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmplead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvEmplea;
        private Label lblNomb;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private Label lblApellidoP;
        private TextBox txtApellidoMaterno;
        private Label lblApellidoMatern;
        private RadioButton rbtnFemenino;
        private Label lblsexo;
        private RadioButton rbtnMasculino;
        private TextBox txtRfc;
        private Label lblRFC;
        private Button btnRegistro;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnRegresar;
        private TextBox txtBuscar;
        private Label lblbuscar;
    }
}