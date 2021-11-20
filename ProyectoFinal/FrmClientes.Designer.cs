namespace ProyectoFinal
{
    partial class FrmClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.lblsexo = new System.Windows.Forms.Label();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMatern = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNomb = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(10, 5);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(659, 579);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnMasculino.Location = new System.Drawing.Point(825, 268);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbtnMasculino.TabIndex = 18;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsexo.Location = new System.Drawing.Point(706, 240);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(32, 15);
            this.lblsexo.TabIndex = 17;
            this.lblsexo.Text = "Sexo";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Checked = true;
            this.rbtnFemenino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFemenino.Location = new System.Drawing.Point(711, 268);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtnFemenino.TabIndex = 16;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(706, 201);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(208, 23);
            this.txtApellidoMaterno.TabIndex = 15;
            // 
            // lblApellidoMatern
            // 
            this.lblApellidoMatern.AutoSize = true;
            this.lblApellidoMatern.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoMatern.Location = new System.Drawing.Point(706, 175);
            this.lblApellidoMatern.Name = "lblApellidoMatern";
            this.lblApellidoMatern.Size = new System.Drawing.Size(99, 15);
            this.lblApellidoMatern.TabIndex = 14;
            this.lblApellidoMatern.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(706, 133);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(208, 23);
            this.txtApellidoPaterno.TabIndex = 13;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidoP.Location = new System.Drawing.Point(706, 109);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(95, 15);
            this.lblApellidoP.TabIndex = 12;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(706, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 11;
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomb.Location = new System.Drawing.Point(706, 44);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(51, 15);
            this.lblNomb.TabIndex = 10;
            this.lblNomb.Text = "Nombre";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(711, 516);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(208, 23);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(711, 485);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(208, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(711, 456);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(208, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(711, 427);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(208, 23);
            this.btnRegistro.TabIndex = 19;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(711, 350);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 23);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbuscar.Location = new System.Drawing.Point(711, 324);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(42, 15);
            this.lblbuscar.TabIndex = 23;
            this.lblbuscar.Text = "Buscar";
            // 
            // FrmClientes
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
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoMatern);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNomb);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClientes;
        private RadioButton rbtnMasculino;
        private Label lblsexo;
        private RadioButton rbtnFemenino;
        private TextBox txtApellidoMaterno;
        private Label lblApellidoMatern;
        private TextBox txtApellidoPaterno;
        private Label lblApellidoP;
        private TextBox txtNombre;
        private Label lblNomb;
        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnRegistro;
        private TextBox txtBuscar;
        private Label lblbuscar;
    }
}