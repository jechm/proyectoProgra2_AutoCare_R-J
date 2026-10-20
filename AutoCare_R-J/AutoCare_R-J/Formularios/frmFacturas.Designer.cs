namespace AutoCare_R_J.Formularios
{
    partial class frmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturas));
            this.cpBusquedas = new AutoCare_R_J.CustomPanel();
            this.gbBuscCod = new System.Windows.Forms.GroupBox();
            this.tbxBuscCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new AutoCare_R_J.CustomButton();
            this.lblBusquedas = new System.Windows.Forms.Label();
            this.cpAccionesRapidas = new AutoCare_R_J.CustomPanel();
            this.btnLimpiarCampos = new AutoCare_R_J.CustomButton();
            this.btnEliminar = new AutoCare_R_J.CustomButton();
            this.btnAgregar = new AutoCare_R_J.CustomButton();
            this.lblAccionesRapidas = new System.Windows.Forms.Label();
            this.customPanel1 = new AutoCare_R_J.CustomPanel();
            this.cbxServicio = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRepuesto = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxVehiculo = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDescuento = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDatosServicio = new System.Windows.Forms.Label();
            this.cpFiltros = new AutoCare_R_J.CustomPanel();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.cpBusquedas.SuspendLayout();
            this.gbBuscCod.SuspendLayout();
            this.cpAccionesRapidas.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // cpBusquedas
            // 
            this.cpBusquedas.BackColor = System.Drawing.Color.Transparent;
            this.cpBusquedas.BorderRadius = 20;
            this.cpBusquedas.Controls.Add(this.gbBuscCod);
            this.cpBusquedas.Controls.Add(this.btnBuscar);
            this.cpBusquedas.Controls.Add(this.lblBusquedas);
            this.cpBusquedas.Location = new System.Drawing.Point(469, 155);
            this.cpBusquedas.Name = "cpBusquedas";
            this.cpBusquedas.Size = new System.Drawing.Size(383, 175);
            this.cpBusquedas.TabIndex = 32;
            // 
            // gbBuscCod
            // 
            this.gbBuscCod.Controls.Add(this.tbxBuscCodigo);
            this.gbBuscCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscCod.Location = new System.Drawing.Point(14, 51);
            this.gbBuscCod.Name = "gbBuscCod";
            this.gbBuscCod.Size = new System.Drawing.Size(362, 53);
            this.gbBuscCod.TabIndex = 31;
            this.gbBuscCod.TabStop = false;
            this.gbBuscCod.Text = "Código";
            // 
            // tbxBuscCodigo
            // 
            this.tbxBuscCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscCodigo.Location = new System.Drawing.Point(16, 21);
            this.tbxBuscCodigo.Name = "tbxBuscCodigo";
            this.tbxBuscCodigo.Size = new System.Drawing.Size(340, 26);
            this.tbxBuscCodigo.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderRadius = 15;
            this.btnBuscar.ButtonIcon = global::AutoCare_R_J.Properties.Resources.buscar;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(194, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 45);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            this.cpAccionesRapidas.Controls.Add(this.btnLimpiarCampos);
            this.cpAccionesRapidas.Controls.Add(this.btnEliminar);
            this.cpAccionesRapidas.Controls.Add(this.btnAgregar);
            this.cpAccionesRapidas.Controls.Add(this.lblAccionesRapidas);
            this.cpAccionesRapidas.Location = new System.Drawing.Point(469, 3);
            this.cpAccionesRapidas.Name = "cpAccionesRapidas";
            this.cpAccionesRapidas.Size = new System.Drawing.Size(383, 146);
            this.cpAccionesRapidas.TabIndex = 31;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCampos.BorderRadius = 15;
            this.btnLimpiarCampos.ButtonIcon = global::AutoCare_R_J.Properties.Resources.limpiar;
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.CustomBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.IconSize = new System.Drawing.Size(20, 20);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(194, 39);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(160, 45);
            this.btnLimpiarCampos.TabIndex = 29;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.ButtonIcon = global::AutoCare_R_J.Properties.Resources.nulo;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(14, 91);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 45);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderRadius = 15;
            this.btnAgregar.ButtonIcon = global::AutoCare_R_J.Properties.Resources.salvar;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.CustomBackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(14, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 45);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Guardar nuevo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblAccionesRapidas
            // 
            this.lblAccionesRapidas.AutoSize = true;
            this.lblAccionesRapidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionesRapidas.Location = new System.Drawing.Point(8, 7);
            this.lblAccionesRapidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccionesRapidas.Name = "lblAccionesRapidas";
            this.lblAccionesRapidas.Size = new System.Drawing.Size(178, 24);
            this.lblAccionesRapidas.TabIndex = 25;
            this.lblAccionesRapidas.Text = "Acciones Rapidas";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.Controls.Add(this.cbxServicio);
            this.customPanel1.Controls.Add(this.pictureBox7);
            this.customPanel1.Controls.Add(this.tbxDescripcion);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.cbxRepuesto);
            this.customPanel1.Controls.Add(this.pictureBox5);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.cbxVehiculo);
            this.customPanel1.Controls.Add(this.pictureBox4);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.dtpFecha);
            this.customPanel1.Controls.Add(this.pictureBox3);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.cbxDescuento);
            this.customPanel1.Controls.Add(this.pictureBox2);
            this.customPanel1.Controls.Add(this.lblDescuento);
            this.customPanel1.Controls.Add(this.pictureBox6);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Controls.Add(this.tbxCodigo);
            this.customPanel1.Controls.Add(this.lblCodigo);
            this.customPanel1.Controls.Add(this.lblDatosServicio);
            this.customPanel1.Location = new System.Drawing.Point(9, 2);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(455, 328);
            this.customPanel1.TabIndex = 33;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // cbxServicio
            // 
            this.cbxServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServicio.FormattingEnabled = true;
            this.cbxServicio.Location = new System.Drawing.Point(125, 59);
            this.cbxServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cbxServicio.Name = "cbxServicio";
            this.cbxServicio.Size = new System.Drawing.Size(272, 28);
            this.cbxServicio.TabIndex = 51;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AutoCare_R_J.Properties.Resources.servicio;
            this.pictureBox7.Location = new System.Drawing.Point(6, 225);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Enabled = false;
            this.tbxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(144, 222);
            this.tbxDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(295, 92);
            this.tbxDescripcion.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(32, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Descripción:";
            // 
            // cbxRepuesto
            // 
            this.cbxRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRepuesto.FormattingEnabled = true;
            this.cbxRepuesto.Location = new System.Drawing.Point(125, 188);
            this.cbxRepuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRepuesto.Name = "cbxRepuesto";
            this.cbxRepuesto.Size = new System.Drawing.Size(257, 28);
            this.cbxRepuesto.TabIndex = 47;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AutoCare_R_J.Properties.Resources.repuesto;
            this.pictureBox5.Location = new System.Drawing.Point(6, 195);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(29, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Repuesto:";
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiculo.FormattingEnabled = true;
            this.cbxVehiculo.Location = new System.Drawing.Point(110, 153);
            this.cbxVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Size = new System.Drawing.Size(272, 28);
            this.cbxVehiculo.TabIndex = 44;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AutoCare_R_J.Properties.Resources.coche;
            this.pictureBox4.Location = new System.Drawing.Point(6, 160);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vehiculo:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(100, 122);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(282, 26);
            this.dtpFecha.TabIndex = 41;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AutoCare_R_J.Properties.Resources.calendario;
            this.pictureBox3.Location = new System.Drawing.Point(6, 126);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha:";
            // 
            // cbxDescuento
            // 
            this.cbxDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDescuento.FormattingEnabled = true;
            this.cbxDescuento.Items.AddRange(new object[] {
            "5%",
            "10%",
            "15%",
            "20%"});
            this.cbxDescuento.Location = new System.Drawing.Point(136, 90);
            this.cbxDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDescuento.Name = "cbxDescuento";
            this.cbxDescuento.Size = new System.Drawing.Size(64, 28);
            this.cbxDescuento.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoCare_R_J.Properties.Resources.descuento;
            this.pictureBox2.Location = new System.Drawing.Point(6, 92);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescuento.Location = new System.Drawing.Point(32, 93);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(101, 20);
            this.lblDescuento.TabIndex = 33;
            this.lblDescuento.Text = "Descuento:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AutoCare_R_J.Properties.Resources.servicio;
            this.pictureBox6.Location = new System.Drawing.Point(6, 64);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Servicio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCare_R_J.Properties.Resources.escanear;
            this.pictureBox1.Location = new System.Drawing.Point(6, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(100, 30);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(87, 26);
            this.tbxCodigo.TabIndex = 28;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.Location = new System.Drawing.Point(32, 35);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDatosServicio
            // 
            this.lblDatosServicio.AutoSize = true;
            this.lblDatosServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosServicio.Location = new System.Drawing.Point(2, 5);
            this.lblDatosServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosServicio.Name = "lblDatosServicio";
            this.lblDatosServicio.Size = new System.Drawing.Size(182, 24);
            this.lblDatosServicio.TabIndex = 26;
            this.lblDatosServicio.Text = "Datos de la factura";
            // 
            // cpFiltros
            // 
            this.cpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.cpFiltros.BorderRadius = 20;
            this.cpFiltros.Location = new System.Drawing.Point(7, 334);
            this.cpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.cpFiltros.Name = "cpFiltros";
            this.cpFiltros.Size = new System.Drawing.Size(845, 57);
            this.cpFiltros.TabIndex = 35;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(8, 395);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.Size = new System.Drawing.Size(845, 205);
            this.dgvFacturas.TabIndex = 36;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.cpFiltros);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.cpBusquedas);
            this.Controls.Add(this.cpAccionesRapidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.cpBusquedas.ResumeLayout(false);
            this.cpBusquedas.PerformLayout();
            this.gbBuscCod.ResumeLayout(false);
            this.gbBuscCod.PerformLayout();
            this.cpAccionesRapidas.ResumeLayout(false);
            this.cpAccionesRapidas.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel cpBusquedas;
        private System.Windows.Forms.GroupBox gbBuscCod;
        private System.Windows.Forms.TextBox tbxBuscCodigo;
        private CustomButton btnBuscar;
        private System.Windows.Forms.Label lblBusquedas;
        private CustomPanel cpAccionesRapidas;
        private CustomButton btnLimpiarCampos;
        private CustomButton btnEliminar;
        private CustomButton btnAgregar;
        private System.Windows.Forms.Label lblAccionesRapidas;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label lblDatosServicio;
        private CustomPanel cpFiltros;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.ComboBox cbxVehiculo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDescuento;
        private System.Windows.Forms.ComboBox cbxRepuesto;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxServicio;
    }
}