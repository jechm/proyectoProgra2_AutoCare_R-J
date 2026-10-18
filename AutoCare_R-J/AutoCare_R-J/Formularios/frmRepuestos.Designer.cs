namespace AutoCare_R_J.Formularios
{
    partial class frmRepuestos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            this.pnlMenus = new System.Windows.Forms.Panel();
            this.dtGvDatos = new System.Windows.Forms.DataGridView();
            this.cpBusquedas = new AutoCare_R_J.CustomPanel();
            this.btnBuscarCliente = new AutoCare_R_J.CustomButton();
            this.gbValorABuscar = new System.Windows.Forms.GroupBox();
            this.txtValorAbuscar = new System.Windows.Forms.TextBox();
            this.gbValorDeBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbValoresDeBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBusquedas = new System.Windows.Forms.Label();
            this.cpAccionesRapidas = new AutoCare_R_J.CustomPanel();
            this.btnEliminarCliente = new AutoCare_R_J.CustomButton();
            this.btnLimpiar = new AutoCare_R_J.CustomButton();
            this.btnModificarCliente = new AutoCare_R_J.CustomButton();
            this.bntNuevoCliente = new AutoCare_R_J.CustomButton();
            this.lblAccionesRapidas = new System.Windows.Forms.Label();
            this.cstmPnlDatosCliente = new AutoCare_R_J.CustomPanel();
            this.nudExistencias = new System.Windows.Forms.NumericUpDown();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDatosRepuesto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvDatos)).BeginInit();
            this.cpBusquedas.SuspendLayout();
            this.gbValorABuscar.SuspendLayout();
            this.gbValorDeBusqueda.SuspendLayout();
            this.cpAccionesRapidas.SuspendLayout();
            this.cstmPnlDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenus
            // 
            this.pnlMenus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenus.Controls.Add(this.cpBusquedas);
            this.pnlMenus.Controls.Add(this.cpAccionesRapidas);
            this.pnlMenus.Controls.Add(this.cstmPnlDatosCliente);
            this.pnlMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenus.Location = new System.Drawing.Point(0, 0);
            this.pnlMenus.Name = "pnlMenus";
            this.pnlMenus.Size = new System.Drawing.Size(1081, 332);
            this.pnlMenus.TabIndex = 27;
            // 
            // dtGvDatos
            // 
            this.dtGvDatos.AllowUserToAddRows = false;
            this.dtGvDatos.AllowUserToDeleteRows = false;
            this.dtGvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtGvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGvDatos.Location = new System.Drawing.Point(0, 332);
            this.dtGvDatos.MultiSelect = false;
            this.dtGvDatos.Name = "dtGvDatos";
            this.dtGvDatos.ReadOnly = true;
            this.dtGvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGvDatos.Size = new System.Drawing.Size(1081, 312);
            this.dtGvDatos.TabIndex = 28;
            this.dtGvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGvDatos_CellClick);
            // 
            // cpBusquedas
            // 
            this.cpBusquedas.BackColor = System.Drawing.Color.Transparent;
            this.cpBusquedas.BorderRadius = 20;
            this.cpBusquedas.Controls.Add(this.btnBuscarCliente);
            this.cpBusquedas.Controls.Add(this.gbValorABuscar);
            this.cpBusquedas.Controls.Add(this.gbValorDeBusqueda);
            this.cpBusquedas.Controls.Add(this.lblBusquedas);
            this.cpBusquedas.Location = new System.Drawing.Point(693, 154);
            this.cpBusquedas.Name = "cpBusquedas";
            this.cpBusquedas.Size = new System.Drawing.Size(383, 172);
            this.cpBusquedas.TabIndex = 32;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BorderRadius = 15;
            this.btnBuscarCliente.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.ButtonIcon")));
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconSize = new System.Drawing.Size(20, 20);
            this.btnBuscarCliente.Location = new System.Drawing.Point(188, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(182, 45);
            this.btnBuscarCliente.TabIndex = 15;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // gbValorABuscar
            // 
            this.gbValorABuscar.Controls.Add(this.txtValorAbuscar);
            this.gbValorABuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValorABuscar.Location = new System.Drawing.Point(14, 108);
            this.gbValorABuscar.Name = "gbValorABuscar";
            this.gbValorABuscar.Size = new System.Drawing.Size(362, 53);
            this.gbValorABuscar.TabIndex = 32;
            this.gbValorABuscar.TabStop = false;
            this.gbValorABuscar.Text = "Ingrese el Codigo";
            // 
            // txtValorAbuscar
            // 
            this.txtValorAbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorAbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAbuscar.Location = new System.Drawing.Point(6, 21);
            this.txtValorAbuscar.Name = "txtValorAbuscar";
            this.txtValorAbuscar.Size = new System.Drawing.Size(350, 26);
            this.txtValorAbuscar.TabIndex = 14;
            // 
            // gbValorDeBusqueda
            // 
            this.gbValorDeBusqueda.Controls.Add(this.cmbValoresDeBusqueda);
            this.gbValorDeBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValorDeBusqueda.Location = new System.Drawing.Point(14, 51);
            this.gbValorDeBusqueda.Name = "gbValorDeBusqueda";
            this.gbValorDeBusqueda.Size = new System.Drawing.Size(362, 53);
            this.gbValorDeBusqueda.TabIndex = 31;
            this.gbValorDeBusqueda.TabStop = false;
            this.gbValorDeBusqueda.Text = "Buscar Por:";
            // 
            // cmbValoresDeBusqueda
            // 
            this.cmbValoresDeBusqueda.FormattingEnabled = true;
            this.cmbValoresDeBusqueda.Location = new System.Drawing.Point(6, 19);
            this.cmbValoresDeBusqueda.Name = "cmbValoresDeBusqueda";
            this.cmbValoresDeBusqueda.Size = new System.Drawing.Size(350, 24);
            this.cmbValoresDeBusqueda.TabIndex = 13;
            this.cmbValoresDeBusqueda.Text = "Escoger campo";
            this.cmbValoresDeBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbValoresDeBusqueda_SelectedIndexChanged);
            // 
            // lblBusquedas
            // 
            this.lblBusquedas.AutoSize = true;
            this.lblBusquedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedas.Location = new System.Drawing.Point(10, 13);
            this.lblBusquedas.Name = "lblBusquedas";
            this.lblBusquedas.Size = new System.Drawing.Size(114, 24);
            this.lblBusquedas.TabIndex = 29;
            this.lblBusquedas.Text = "Busquedas";
            // 
            // cpAccionesRapidas
            // 
            this.cpAccionesRapidas.BackColor = System.Drawing.Color.Transparent;
            this.cpAccionesRapidas.BorderRadius = 20;
            this.cpAccionesRapidas.Controls.Add(this.btnEliminarCliente);
            this.cpAccionesRapidas.Controls.Add(this.btnLimpiar);
            this.cpAccionesRapidas.Controls.Add(this.btnModificarCliente);
            this.cpAccionesRapidas.Controls.Add(this.bntNuevoCliente);
            this.cpAccionesRapidas.Controls.Add(this.lblAccionesRapidas);
            this.cpAccionesRapidas.Location = new System.Drawing.Point(693, 5);
            this.cpAccionesRapidas.Name = "cpAccionesRapidas";
            this.cpAccionesRapidas.Size = new System.Drawing.Size(383, 146);
            this.cpAccionesRapidas.TabIndex = 31;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.BorderRadius = 15;
            this.btnEliminarCliente.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.ButtonIcon")));
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.CustomBackColor = System.Drawing.Color.SlateGray;
            this.btnEliminarCliente.Enabled = false;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.IconSize = new System.Drawing.Size(20, 20);
            this.btnEliminarCliente.Location = new System.Drawing.Point(14, 91);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(168, 45);
            this.btnEliminarCliente.TabIndex = 13;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BorderRadius = 15;
            this.btnLimpiar.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ButtonIcon")));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconSize = new System.Drawing.Size(20, 20);
            this.btnLimpiar.Location = new System.Drawing.Point(188, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(182, 45);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarCliente.BorderRadius = 15;
            this.btnModificarCliente.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("btnModificarCliente.ButtonIcon")));
            this.btnModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCliente.CustomBackColor = System.Drawing.Color.SlateGray;
            this.btnModificarCliente.Enabled = false;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificarCliente.IconSize = new System.Drawing.Size(20, 20);
            this.btnModificarCliente.Location = new System.Drawing.Point(187, 40);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(182, 45);
            this.btnModificarCliente.TabIndex = 12;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // bntNuevoCliente
            // 
            this.bntNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.bntNuevoCliente.BorderRadius = 15;
            this.bntNuevoCliente.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("bntNuevoCliente.ButtonIcon")));
            this.bntNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntNuevoCliente.CustomBackColor = System.Drawing.Color.Green;
            this.bntNuevoCliente.FlatAppearance.BorderSize = 0;
            this.bntNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bntNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.bntNuevoCliente.IconSize = new System.Drawing.Size(20, 20);
            this.bntNuevoCliente.Location = new System.Drawing.Point(14, 40);
            this.bntNuevoCliente.Name = "bntNuevoCliente";
            this.bntNuevoCliente.Size = new System.Drawing.Size(168, 45);
            this.bntNuevoCliente.TabIndex = 11;
            this.bntNuevoCliente.Text = "Guardar Nuevo";
            this.bntNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // lblAccionesRapidas
            // 
            this.lblAccionesRapidas.AutoSize = true;
            this.lblAccionesRapidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionesRapidas.Location = new System.Drawing.Point(10, 9);
            this.lblAccionesRapidas.Name = "lblAccionesRapidas";
            this.lblAccionesRapidas.Size = new System.Drawing.Size(178, 24);
            this.lblAccionesRapidas.TabIndex = 25;
            this.lblAccionesRapidas.Text = "Acciones Rapidas";
            // 
            // cstmPnlDatosCliente
            // 
            this.cstmPnlDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.cstmPnlDatosCliente.BorderRadius = 20;
            this.cstmPnlDatosCliente.Controls.Add(this.nudExistencias);
            this.cstmPnlDatosCliente.Controls.Add(this.cmbEstado);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox7);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox5);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox3);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox9);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox8);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox6);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox2);
            this.cstmPnlDatosCliente.Controls.Add(this.lblDatosRepuesto);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox1);
            this.cstmPnlDatosCliente.Controls.Add(this.txtCodigo);
            this.cstmPnlDatosCliente.Controls.Add(this.lblCodigo);
            this.cstmPnlDatosCliente.Controls.Add(this.txtMarca);
            this.cstmPnlDatosCliente.Controls.Add(this.txtCategoria);
            this.cstmPnlDatosCliente.Controls.Add(this.lblExistencias);
            this.cstmPnlDatosCliente.Controls.Add(this.lblMarca);
            this.cstmPnlDatosCliente.Controls.Add(this.lblCategoria);
            this.cstmPnlDatosCliente.Controls.Add(this.txtDescripcion);
            this.cstmPnlDatosCliente.Controls.Add(this.txtPrecio);
            this.cstmPnlDatosCliente.Controls.Add(this.txtNombre);
            this.cstmPnlDatosCliente.Controls.Add(this.label1);
            this.cstmPnlDatosCliente.Controls.Add(this.lblDescripcion);
            this.cstmPnlDatosCliente.Controls.Add(this.lblPrecio);
            this.cstmPnlDatosCliente.Controls.Add(this.lblNombre);
            this.cstmPnlDatosCliente.Location = new System.Drawing.Point(6, 5);
            this.cstmPnlDatosCliente.Name = "cstmPnlDatosCliente";
            this.cstmPnlDatosCliente.Size = new System.Drawing.Size(685, 321);
            this.cstmPnlDatosCliente.TabIndex = 24;
            // 
            // nudExistencias
            // 
            this.nudExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExistencias.Location = new System.Drawing.Point(481, 216);
            this.nudExistencias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExistencias.Name = "nudExistencias";
            this.nudExistencias.Size = new System.Drawing.Size(190, 26);
            this.nudExistencias.TabIndex = 15;
            this.nudExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 20;
            this.cmbEstado.Location = new System.Drawing.Point(121, 271);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(211, 28);
            this.cmbEstado.TabIndex = 9;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AutoCare_R_J.Properties.Resources.descripcion_del_trabajo;
            this.pictureBox7.Location = new System.Drawing.Point(343, 214);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AutoCare_R_J.Properties.Resources.categoria;
            this.pictureBox5.Location = new System.Drawing.Point(343, 165);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AutoCare_R_J.Properties.Resources.categoria;
            this.pictureBox3.Location = new System.Drawing.Point(4, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(4, 270);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AutoCare_R_J.Properties.Resources.editar;
            this.pictureBox8.Location = new System.Drawing.Point(4, 120);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AutoCare_R_J.Properties.Resources.moneda;
            this.pictureBox6.Location = new System.Drawing.Point(4, 216);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoCare_R_J.Properties.Resources.modelado_3d;
            this.pictureBox2.Location = new System.Drawing.Point(4, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lblDatosRepuesto
            // 
            this.lblDatosRepuesto.AutoSize = true;
            this.lblDatosRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosRepuesto.Location = new System.Drawing.Point(13, 9);
            this.lblDatosRepuesto.Name = "lblDatosRepuesto";
            this.lblDatosRepuesto.Size = new System.Drawing.Size(192, 24);
            this.lblDatosRepuesto.TabIndex = 25;
            this.lblDatosRepuesto.Text = "Datos del Repuesto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(107, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.Location = new System.Drawing.Point(31, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(446, 165);
            this.txtMarca.MaxLength = 13;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(225, 26);
            this.txtMarca.TabIndex = 5;
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(124, 162);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(208, 26);
            this.txtCategoria.TabIndex = 3;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencias.Location = new System.Drawing.Point(370, 217);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(105, 20);
            this.lblExistencias.TabIndex = 2;
            this.lblExistencias.Text = "Existencias:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(370, 168);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 20);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(31, 165);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(92, 20);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(145, 120);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(526, 26);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(121, 216);
            this.txtPrecio.MaxLength = 8;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(211, 26);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(107, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(564, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(31, 219);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 644);
            this.Controls.Add(this.dtGvDatos);
            this.Controls.Add(this.pnlMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 600);
            this.Name = "frmRepuestos";
            this.Text = "Repuestos";
            this.pnlMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGvDatos)).EndInit();
            this.cpBusquedas.ResumeLayout(false);
            this.cpBusquedas.PerformLayout();
            this.gbValorABuscar.ResumeLayout(false);
            this.gbValorABuscar.PerformLayout();
            this.gbValorDeBusqueda.ResumeLayout(false);
            this.cpAccionesRapidas.ResumeLayout(false);
            this.cpAccionesRapidas.PerformLayout();
            this.cstmPnlDatosCliente.ResumeLayout(false);
            this.cstmPnlDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenus;
        private CustomPanel cpBusquedas;
        private CustomButton btnBuscarCliente;
        private System.Windows.Forms.GroupBox gbValorABuscar;
        private System.Windows.Forms.TextBox txtValorAbuscar;
        private System.Windows.Forms.GroupBox gbValorDeBusqueda;
        private System.Windows.Forms.ComboBox cmbValoresDeBusqueda;
        private System.Windows.Forms.Label lblBusquedas;
        private CustomPanel cpAccionesRapidas;
        private CustomButton btnEliminarCliente;
        private CustomButton btnLimpiar;
        private CustomButton btnModificarCliente;
        private CustomButton bntNuevoCliente;
        private System.Windows.Forms.Label lblAccionesRapidas;
        private CustomPanel cstmPnlDatosCliente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDatosRepuesto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtGvDatos;
        private System.Windows.Forms.NumericUpDown nudExistencias;
    }
}