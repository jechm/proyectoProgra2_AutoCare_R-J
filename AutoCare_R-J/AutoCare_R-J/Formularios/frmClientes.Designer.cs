namespace AutoCare_R_J.Formularios
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvColCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColNit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOpcionesClientes = new System.Windows.Forms.Panel();
            this.gpbBusquar = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorBuscado = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlOpcionesClientes.SuspendLayout();
            this.gpbBusquar.SuspendLayout();
            this.gpbFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(156, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 50);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCodigoCliente,
            this.dgvColNombres,
            this.dgvColApellidos,
            this.dgvColDPI,
            this.dgvColCorreo,
            this.dgvColNit,
            this.dgvColDireccion,
            this.dgvColSaldo,
            this.dgvColEstado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(858, 427);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgvColCodigoCliente
            // 
            this.dgvColCodigoCliente.HeaderText = "Codigo";
            this.dgvColCodigoCliente.Name = "dgvColCodigoCliente";
            this.dgvColCodigoCliente.ReadOnly = true;
            // 
            // dgvColNombres
            // 
            this.dgvColNombres.HeaderText = "Nombres";
            this.dgvColNombres.Name = "dgvColNombres";
            this.dgvColNombres.ReadOnly = true;
            // 
            // dgvColApellidos
            // 
            this.dgvColApellidos.HeaderText = "Apellidos";
            this.dgvColApellidos.Name = "dgvColApellidos";
            this.dgvColApellidos.ReadOnly = true;
            // 
            // dgvColDPI
            // 
            this.dgvColDPI.HeaderText = "DPI";
            this.dgvColDPI.Name = "dgvColDPI";
            this.dgvColDPI.ReadOnly = true;
            // 
            // dgvColCorreo
            // 
            this.dgvColCorreo.HeaderText = "Correo";
            this.dgvColCorreo.Name = "dgvColCorreo";
            this.dgvColCorreo.ReadOnly = true;
            // 
            // dgvColNit
            // 
            this.dgvColNit.HeaderText = "Nit";
            this.dgvColNit.Name = "dgvColNit";
            this.dgvColNit.ReadOnly = true;
            // 
            // dgvColDireccion
            // 
            this.dgvColDireccion.HeaderText = "Dirección";
            this.dgvColDireccion.Name = "dgvColDireccion";
            this.dgvColDireccion.ReadOnly = true;
            // 
            // dgvColSaldo
            // 
            this.dgvColSaldo.HeaderText = "Saldo";
            this.dgvColSaldo.Name = "dgvColSaldo";
            this.dgvColSaldo.ReadOnly = true;
            // 
            // dgvColEstado
            // 
            this.dgvColEstado.HeaderText = "Estado";
            this.dgvColEstado.Name = "dgvColEstado";
            this.dgvColEstado.ReadOnly = true;
            // 
            // pnlOpcionesClientes
            // 
            this.pnlOpcionesClientes.AutoScroll = true;
            this.pnlOpcionesClientes.Controls.Add(this.gpbBusquar);
            this.pnlOpcionesClientes.Controls.Add(this.gpbFiltros);
            this.pnlOpcionesClientes.Controls.Add(this.btnNuevo);
            this.pnlOpcionesClientes.Controls.Add(this.btnModificar);
            this.pnlOpcionesClientes.Controls.Add(this.btnEliminar);
            this.pnlOpcionesClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpcionesClientes.Location = new System.Drawing.Point(0, 0);
            this.pnlOpcionesClientes.Name = "pnlOpcionesClientes";
            this.pnlOpcionesClientes.Size = new System.Drawing.Size(858, 100);
            this.pnlOpcionesClientes.TabIndex = 4;
            // 
            // gpbBusquar
            // 
            this.gpbBusquar.Controls.Add(this.textBox1);
            this.gpbBusquar.Controls.Add(this.label4);
            this.gpbBusquar.Controls.Add(this.lblValorBuscado);
            this.gpbBusquar.Controls.Add(this.comboBox3);
            this.gpbBusquar.Controls.Add(this.button1);
            this.gpbBusquar.Location = new System.Drawing.Point(470, 13);
            this.gpbBusquar.Name = "gpbBusquar";
            this.gpbBusquar.Size = new System.Drawing.Size(282, 70);
            this.gpbBusquar.TabIndex = 7;
            this.gpbBusquar.TabStop = false;
            this.gpbBusquar.Text = "Buscar";
            this.gpbBusquar.Enter += new System.EventHandler(this.gpbBusquar_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Columna";
            // 
            // lblValorBuscado
            // 
            this.lblValorBuscado.AutoSize = true;
            this.lblValorBuscado.Location = new System.Drawing.Point(6, 45);
            this.lblValorBuscado.Name = "lblValorBuscado";
            this.lblValorBuscado.Size = new System.Drawing.Size(35, 13);
            this.lblValorBuscado.TabIndex = 6;
            this.lblValorBuscado.Text = "label3";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "DPI",
            "NIT"});
            this.comboBox3.Location = new System.Drawing.Point(63, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.label2);
            this.gpbFiltros.Controls.Add(this.label1);
            this.gpbFiltros.Controls.Add(this.comboBox2);
            this.gpbFiltros.Controls.Add(this.comboBox1);
            this.gpbFiltros.Controls.Add(this.btnFiltrar);
            this.gpbFiltros.Location = new System.Drawing.Point(174, 12);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(289, 71);
            this.gpbFiltros.TabIndex = 5;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Columna";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(76, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(203, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 46);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 427);
            this.panel1.TabIndex = 5;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOpcionesClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlOpcionesClientes.ResumeLayout(false);
            this.gpbBusquar.ResumeLayout(false);
            this.gpbBusquar.PerformLayout();
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlOpcionesClientes;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gpbBusquar;
        private System.Windows.Forms.Label lblValorBuscado;
        private System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColNit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEstado;
        private System.Windows.Forms.Panel panel1;
    }
}