namespace AutoCare_R_J.Formularios
{
    partial class frmCitas
    {

        //borrar este comentario del 231026


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            this.pnlMenus = new System.Windows.Forms.Panel();
            this.cstmPnlDato = new AutoCare_R_J.CustomPanel();
            this.dtGvDatos = new System.Windows.Forms.DataGridView();
            this.cpBusquedas = new AutoCare_R_J.CustomPanel();
            this.btnBuscar = new AutoCare_R_J.CustomButton();
            this.gbValorABuscar = new System.Windows.Forms.GroupBox();
            this.txtValorAbuscar = new System.Windows.Forms.TextBox();
            this.gbValorDeBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbValoresDeBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBusquedas = new System.Windows.Forms.Label();
            this.cpAccionesRapidas = new AutoCare_R_J.CustomPanel();
            this.btnEliminar = new AutoCare_R_J.CustomButton();
            this.btnLimpiar = new AutoCare_R_J.CustomButton();
            this.btnModificar = new AutoCare_R_J.CustomButton();
            this.bntNuevo = new AutoCare_R_J.CustomButton();
            this.lblAccionesRapidas = new System.Windows.Forms.Label();
            this.cstmPnlDatosCliente = new AutoCare_R_J.CustomPanel();
            this.dtFechaHora = new System.Windows.Forms.DateTimePicker();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDatosCita = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlMenus.SuspendLayout();
            this.cstmPnlDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvDatos)).BeginInit();
            this.cpBusquedas.SuspendLayout();
            this.gbValorABuscar.SuspendLayout();
            this.gbValorDeBusqueda.SuspendLayout();
            this.cpAccionesRapidas.SuspendLayout();
            this.cstmPnlDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenus
            // 
            this.pnlMenus.BackColor = System.Drawing.Color.SlateGray;
            this.pnlMenus.Controls.Add(this.cpBusquedas);
            this.pnlMenus.Controls.Add(this.cpAccionesRapidas);
            this.pnlMenus.Controls.Add(this.cstmPnlDatosCliente);
            this.pnlMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenus.Location = new System.Drawing.Point(0, 0);
            this.pnlMenus.Name = "pnlMenus";
            this.pnlMenus.Size = new System.Drawing.Size(1078, 332);
            this.pnlMenus.TabIndex = 27;
            // 
            // cstmPnlDato
            // 
            this.cstmPnlDato.BackColor = System.Drawing.Color.Transparent;
            this.cstmPnlDato.BorderRadius = 20;
            this.cstmPnlDato.Controls.Add(this.dtGvDatos);
            this.cstmPnlDato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cstmPnlDato.Location = new System.Drawing.Point(0, 332);
            this.cstmPnlDato.Name = "cstmPnlDato";
            this.cstmPnlDato.Size = new System.Drawing.Size(1078, 271);
            this.cstmPnlDato.TabIndex = 28;
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
            this.dtGvDatos.Location = new System.Drawing.Point(0, 0);
            this.dtGvDatos.MultiSelect = false;
            this.dtGvDatos.Name = "dtGvDatos";
            this.dtGvDatos.ReadOnly = true;
            this.dtGvDatos.RowHeadersWidth = 51;
            this.dtGvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGvDatos.Size = new System.Drawing.Size(1078, 271);
            this.dtGvDatos.TabIndex = 23;
            this.dtGvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGvDatos_CellDoubleClick);
            // 
            // cpBusquedas
            // 
            this.cpBusquedas.BackColor = System.Drawing.Color.Transparent;
            this.cpBusquedas.BorderRadius = 20;
            this.cpBusquedas.Controls.Add(this.btnBuscar);
            this.cpBusquedas.Controls.Add(this.gbValorABuscar);
            this.cpBusquedas.Controls.Add(this.gbValorDeBusqueda);
            this.cpBusquedas.Controls.Add(this.lblBusquedas);
            this.cpBusquedas.Location = new System.Drawing.Point(692, 154);
            this.cpBusquedas.Name = "cpBusquedas";
            this.cpBusquedas.Size = new System.Drawing.Size(383, 172);
            this.cpBusquedas.TabIndex = 32;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderRadius = 15;
            this.btnBuscar.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ButtonIcon")));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(188, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(182, 45);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.cmbValoresDeBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValoresDeBusqueda.FormattingEnabled = true;
            this.cmbValoresDeBusqueda.Location = new System.Drawing.Point(6, 19);
            this.cmbValoresDeBusqueda.Name = "cmbValoresDeBusqueda";
            this.cmbValoresDeBusqueda.Size = new System.Drawing.Size(350, 28);
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
            this.cpAccionesRapidas.Controls.Add(this.btnEliminar);
            this.cpAccionesRapidas.Controls.Add(this.btnLimpiar);
            this.cpAccionesRapidas.Controls.Add(this.btnModificar);
            this.cpAccionesRapidas.Controls.Add(this.bntNuevo);
            this.cpAccionesRapidas.Controls.Add(this.lblAccionesRapidas);
            this.cpAccionesRapidas.Location = new System.Drawing.Point(692, 5);
            this.cpAccionesRapidas.Name = "cpAccionesRapidas";
            this.cpAccionesRapidas.Size = new System.Drawing.Size(383, 146);
            this.cpAccionesRapidas.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ButtonIcon")));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(14, 91);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 45);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("btnModificar.ButtonIcon")));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.CustomBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(187, 40);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(182, 45);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bntNuevo
            // 
            this.bntNuevo.BackColor = System.Drawing.Color.Transparent;
            this.bntNuevo.BorderRadius = 15;
            this.bntNuevo.ButtonIcon = ((System.Drawing.Image)(resources.GetObject("bntNuevo.ButtonIcon")));
            this.bntNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntNuevo.CustomBackColor = System.Drawing.Color.Green;
            this.bntNuevo.FlatAppearance.BorderSize = 0;
            this.bntNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bntNuevo.ForeColor = System.Drawing.Color.White;
            this.bntNuevo.IconSize = new System.Drawing.Size(20, 20);
            this.bntNuevo.Location = new System.Drawing.Point(14, 40);
            this.bntNuevo.Name = "bntNuevo";
            this.bntNuevo.Size = new System.Drawing.Size(168, 45);
            this.bntNuevo.TabIndex = 11;
            this.bntNuevo.Text = "Guardar Nuevo";
            this.bntNuevo.UseVisualStyleBackColor = false;
            this.bntNuevo.Click += new System.EventHandler(this.bntNuevo_Click);
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
            this.cstmPnlDatosCliente.Controls.Add(this.dtFechaHora);
            this.cstmPnlDatosCliente.Controls.Add(this.cmbVehiculo);
            this.cstmPnlDatosCliente.Controls.Add(this.cmbEmpleado);
            this.cstmPnlDatosCliente.Controls.Add(this.cmbCliente);
            this.cstmPnlDatosCliente.Controls.Add(this.cmbEstado);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox3);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox9);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox8);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox6);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox4);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox2);
            this.cstmPnlDatosCliente.Controls.Add(this.lblDatosCita);
            this.cstmPnlDatosCliente.Controls.Add(this.pictureBox1);
            this.cstmPnlDatosCliente.Controls.Add(this.txtCodigo);
            this.cstmPnlDatosCliente.Controls.Add(this.lblCodigo);
            this.cstmPnlDatosCliente.Controls.Add(this.lblVehiculo);
            this.cstmPnlDatosCliente.Controls.Add(this.txtObservaciones);
            this.cstmPnlDatosCliente.Controls.Add(this.label1);
            this.cstmPnlDatosCliente.Controls.Add(this.lblObservaciones);
            this.cstmPnlDatosCliente.Controls.Add(this.lblTecnico);
            this.cstmPnlDatosCliente.Controls.Add(this.lblTelefono);
            this.cstmPnlDatosCliente.Controls.Add(this.lblCliente);
            this.cstmPnlDatosCliente.Location = new System.Drawing.Point(5, 5);
            this.cstmPnlDatosCliente.Name = "cstmPnlDatosCliente";
            this.cstmPnlDatosCliente.Size = new System.Drawing.Size(685, 321);
            this.cstmPnlDatosCliente.TabIndex = 24;
            // 
            // dtFechaHora
            // 
            this.dtFechaHora.CustomFormat = "dd/MM/yyyy - hh:mm";
            this.dtFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaHora.Location = new System.Drawing.Point(447, 79);
            this.dtFechaHora.MinDate = new System.DateTime(2026, 11, 1, 17, 38, 56, 0);
            this.dtFechaHora.Name = "dtFechaHora";
            this.dtFechaHora.Size = new System.Drawing.Size(177, 26);
            this.dtFechaHora.TabIndex = 28;
            this.dtFechaHora.Value = new System.DateTime(2026, 11, 3, 0, 0, 0, 0);
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.ItemHeight = 20;
            this.cmbVehiculo.Location = new System.Drawing.Point(107, 162);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(564, 28);
            this.cmbVehiculo.TabIndex = 9;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.ItemHeight = 20;
            this.cmbEmpleado.Location = new System.Drawing.Point(107, 122);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(211, 28);
            this.cmbEmpleado.TabIndex = 9;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.ItemHeight = 20;
            this.cmbCliente.Location = new System.Drawing.Point(107, 77);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(211, 28);
            this.cmbCliente.TabIndex = 9;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 20;
            this.cmbEstado.Location = new System.Drawing.Point(124, 279);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(211, 28);
            this.cmbEstado.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
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
            this.pictureBox9.Location = new System.Drawing.Point(7, 278);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AutoCare_R_J.Properties.Resources.editar;
            this.pictureBox8.Location = new System.Drawing.Point(4, 212);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AutoCare_R_J.Properties.Resources.calendario;
            this.pictureBox6.Location = new System.Drawing.Point(344, 76);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(4, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lblDatosCita
            // 
            this.lblDatosCita.AutoSize = true;
            this.lblDatosCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCita.Location = new System.Drawing.Point(13, 9);
            this.lblDatosCita.Name = "lblDatosCita";
            this.lblDatosCita.Size = new System.Drawing.Size(165, 24);
            this.lblDatosCita.TabIndex = 25;
            this.lblDatosCita.Text = "Datos del cliente";
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
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(31, 165);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(78, 20);
            this.lblVehiculo.TabIndex = 2;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(164, 212);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(507, 61);
            this.txtObservaciones.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(31, 215);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(127, 20);
            this.lblObservaciones.TabIndex = 2;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.Location = new System.Drawing.Point(31, 123);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(76, 20);
            this.lblTecnico.TabIndex = 2;
            this.lblTecnico.Text = "Tecnico:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(371, 79);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 20);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Fecha:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(31, 82);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 603);
            this.Controls.Add(this.cstmPnlDato);
            this.Controls.Add(this.pnlMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1348, 642);
            this.MinimumSize = new System.Drawing.Size(1094, 642);
            this.Name = "frmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.pnlMenus.ResumeLayout(false);
            this.cstmPnlDato.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenus;
        private CustomPanel cpBusquedas;
        private CustomButton btnBuscar;
        private System.Windows.Forms.GroupBox gbValorABuscar;
        private System.Windows.Forms.TextBox txtValorAbuscar;
        private System.Windows.Forms.GroupBox gbValorDeBusqueda;
        private System.Windows.Forms.ComboBox cmbValoresDeBusqueda;
        private System.Windows.Forms.Label lblBusquedas;
        private CustomPanel cpAccionesRapidas;
        private CustomButton btnEliminar;
        private CustomButton btnLimpiar;
        private CustomButton btnModificar;
        private CustomButton bntNuevo;
        private System.Windows.Forms.Label lblAccionesRapidas;
        private CustomPanel cstmPnlDatosCliente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDatosCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCliente;
        private CustomPanel cstmPnlDato;
        private System.Windows.Forms.DataGridView dtGvDatos;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.DateTimePicker dtFechaHora;
    }
}