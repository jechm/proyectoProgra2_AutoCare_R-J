namespace AutoCare_R_J.Formularios
{
    partial class Servicios
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
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.cpFiltros = new AutoCare_R_J.CustomPanel();
            this.cpBusquedas = new AutoCare_R_J.CustomPanel();
            this.gbBuscName = new System.Windows.Forms.GroupBox();
            this.tbxBuscNombre = new System.Windows.Forms.TextBox();
            this.gbBuscCod = new System.Windows.Forms.GroupBox();
            this.tbxBuscCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new AutoCare_R_J.CustomButton();
            this.lblBusquedas = new System.Windows.Forms.Label();
            this.cpAccionesRapidas = new AutoCare_R_J.CustomPanel();
            this.btnLimpiarCampos = new AutoCare_R_J.CustomButton();
            this.btnEliminar = new AutoCare_R_J.CustomButton();
            this.btnModificar = new AutoCare_R_J.CustomButton();
            this.btnAgregar = new AutoCare_R_J.CustomButton();
            this.lblAccionesRapidas = new System.Windows.Forms.Label();
            this.cpDatosServicio = new AutoCare_R_J.CustomPanel();
            this.btnAumentarTiempo = new AutoCare_R_J.CustomButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxDuracionMinutos = new System.Windows.Forms.TextBox();
            this.lblDatosServicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxDuracionHoras = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.nmCosto = new System.Windows.Forms.NumericUpDown();
            this.lblCosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.cpBusquedas.SuspendLayout();
            this.gbBuscName.SuspendLayout();
            this.gbBuscCod.SuspendLayout();
            this.cpAccionesRapidas.SuspendLayout();
            this.cpDatosServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(12, 412);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.Size = new System.Drawing.Size(841, 187);
            this.dgvServicios.TabIndex = 23;
            // 
            // cpFiltros
            // 
            this.cpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.cpFiltros.BorderRadius = 20;
            this.cpFiltros.Location = new System.Drawing.Point(12, 336);
            this.cpFiltros.Name = "cpFiltros";
            this.cpFiltros.Size = new System.Drawing.Size(841, 70);
            this.cpFiltros.TabIndex = 31;
            // 
            // cpBusquedas
            // 
            this.cpBusquedas.BackColor = System.Drawing.Color.Transparent;
            this.cpBusquedas.BorderRadius = 20;
            this.cpBusquedas.Controls.Add(this.gbBuscName);
            this.cpBusquedas.Controls.Add(this.gbBuscCod);
            this.cpBusquedas.Controls.Add(this.btnBuscar);
            this.cpBusquedas.Controls.Add(this.lblBusquedas);
            this.cpBusquedas.Location = new System.Drawing.Point(470, 155);
            this.cpBusquedas.Name = "cpBusquedas";
            this.cpBusquedas.Size = new System.Drawing.Size(383, 175);
            this.cpBusquedas.TabIndex = 30;
            // 
            // gbBuscName
            // 
            this.gbBuscName.Controls.Add(this.tbxBuscNombre);
            this.gbBuscName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscName.Location = new System.Drawing.Point(14, 113);
            this.gbBuscName.Name = "gbBuscName";
            this.gbBuscName.Size = new System.Drawing.Size(362, 53);
            this.gbBuscName.TabIndex = 32;
            this.gbBuscName.TabStop = false;
            this.gbBuscName.Text = "Nombre";
            // 
            // tbxBuscNombre
            // 
            this.tbxBuscNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscNombre.Location = new System.Drawing.Point(16, 21);
            this.tbxBuscNombre.Name = "tbxBuscNombre";
            this.tbxBuscNombre.Size = new System.Drawing.Size(340, 26);
            this.tbxBuscNombre.TabIndex = 29;
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
            this.btnBuscar.Location = new System.Drawing.Point(216, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 45);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.cpAccionesRapidas.Controls.Add(this.btnModificar);
            this.cpAccionesRapidas.Controls.Add(this.btnAgregar);
            this.cpAccionesRapidas.Controls.Add(this.lblAccionesRapidas);
            this.cpAccionesRapidas.Location = new System.Drawing.Point(470, 3);
            this.cpAccionesRapidas.Name = "cpAccionesRapidas";
            this.cpAccionesRapidas.Size = new System.Drawing.Size(383, 146);
            this.cpAccionesRapidas.TabIndex = 29;
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(210, 91);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(160, 45);
            this.btnLimpiarCampos.TabIndex = 29;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.ButtonIcon = global::AutoCare_R_J.Properties.Resources.eliminar;
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
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.ButtonIcon = global::AutoCare_R_J.Properties.Resources.editar;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.CustomBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(210, 39);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 45);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // cpDatosServicio
            // 
            this.cpDatosServicio.BackColor = System.Drawing.Color.Transparent;
            this.cpDatosServicio.BorderRadius = 20;
            this.cpDatosServicio.Controls.Add(this.btnAumentarTiempo);
            this.cpDatosServicio.Controls.Add(this.pictureBox6);
            this.cpDatosServicio.Controls.Add(this.pictureBox5);
            this.cpDatosServicio.Controls.Add(this.pictureBox4);
            this.cpDatosServicio.Controls.Add(this.lblMinutos);
            this.cpDatosServicio.Controls.Add(this.pictureBox3);
            this.cpDatosServicio.Controls.Add(this.pictureBox2);
            this.cpDatosServicio.Controls.Add(this.tbxDuracionMinutos);
            this.cpDatosServicio.Controls.Add(this.lblDatosServicio);
            this.cpDatosServicio.Controls.Add(this.pictureBox1);
            this.cpDatosServicio.Controls.Add(this.lblHoras);
            this.cpDatosServicio.Controls.Add(this.tbxCodigo);
            this.cpDatosServicio.Controls.Add(this.lblCodigo);
            this.cpDatosServicio.Controls.Add(this.tbxDuracionHoras);
            this.cpDatosServicio.Controls.Add(this.tbxNombre);
            this.cpDatosServicio.Controls.Add(this.lblDuracion);
            this.cpDatosServicio.Controls.Add(this.lblNombre);
            this.cpDatosServicio.Controls.Add(this.cbxCategoria);
            this.cpDatosServicio.Controls.Add(this.lblCategoria);
            this.cpDatosServicio.Controls.Add(this.tbxDescripcion);
            this.cpDatosServicio.Controls.Add(this.lblDesc);
            this.cpDatosServicio.Controls.Add(this.nmCosto);
            this.cpDatosServicio.Controls.Add(this.lblCosto);
            this.cpDatosServicio.Location = new System.Drawing.Point(12, 3);
            this.cpDatosServicio.Name = "cpDatosServicio";
            this.cpDatosServicio.Size = new System.Drawing.Size(452, 327);
            this.cpDatosServicio.TabIndex = 24;
            this.cpDatosServicio.Paint += new System.Windows.Forms.PaintEventHandler(this.cpDatosServicio_Paint);
            // 
            // btnAumentarTiempo
            // 
            this.btnAumentarTiempo.BackColor = System.Drawing.Color.Transparent;
            this.btnAumentarTiempo.BorderRadius = 15;
            this.btnAumentarTiempo.ButtonIcon = global::AutoCare_R_J.Properties.Resources.mas;
            this.btnAumentarTiempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentarTiempo.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAumentarTiempo.FlatAppearance.BorderSize = 0;
            this.btnAumentarTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentarTiempo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAumentarTiempo.ForeColor = System.Drawing.Color.White;
            this.btnAumentarTiempo.IconSize = new System.Drawing.Size(20, 20);
            this.btnAumentarTiempo.Location = new System.Drawing.Point(335, 265);
            this.btnAumentarTiempo.Name = "btnAumentarTiempo";
            this.btnAumentarTiempo.Size = new System.Drawing.Size(106, 45);
            this.btnAumentarTiempo.TabIndex = 28;
            this.btnAumentarTiempo.Text = "Auemtar\r\ntiempo";
            this.btnAumentarTiempo.UseVisualStyleBackColor = false;
            this.btnAumentarTiempo.Click += new System.EventHandler(this.btnAumentarTiempo_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AutoCare_R_J.Properties.Resources.repetir;
            this.pictureBox6.Location = new System.Drawing.Point(7, 265);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AutoCare_R_J.Properties.Resources.descripcion_del_trabajo;
            this.pictureBox5.Location = new System.Drawing.Point(5, 166);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AutoCare_R_J.Properties.Resources.moneda;
            this.pictureBox4.Location = new System.Drawing.Point(4, 134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(272, 271);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(65, 20);
            this.lblMinutos.TabIndex = 16;
            this.lblMinutos.Text = "Minutos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AutoCare_R_J.Properties.Resources.categoria;
            this.pictureBox3.Location = new System.Drawing.Point(4, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoCare_R_J.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(4, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // tbxDuracionMinutos
            // 
            this.tbxDuracionMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDuracionMinutos.Location = new System.Drawing.Point(227, 265);
            this.tbxDuracionMinutos.Name = "tbxDuracionMinutos";
            this.tbxDuracionMinutos.Size = new System.Drawing.Size(45, 26);
            this.tbxDuracionMinutos.TabIndex = 15;
            this.tbxDuracionMinutos.Text = "0";
            // 
            // lblDatosServicio
            // 
            this.lblDatosServicio.AutoSize = true;
            this.lblDatosServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosServicio.Location = new System.Drawing.Point(13, 9);
            this.lblDatosServicio.Name = "lblDatosServicio";
            this.lblDatosServicio.Size = new System.Drawing.Size(175, 24);
            this.lblDatosServicio.TabIndex = 25;
            this.lblDatosServicio.Text = "Datos del servicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCare_R_J.Properties.Resources.escanear;
            this.pictureBox1.Location = new System.Drawing.Point(4, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(175, 268);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(52, 20);
            this.lblHoras.TabIndex = 14;
            this.lblHoras.Text = "Horas";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(107, 36);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(115, 26);
            this.tbxCodigo.TabIndex = 1;
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
            // tbxDuracionHoras
            // 
            this.tbxDuracionHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDuracionHoras.Location = new System.Drawing.Point(130, 265);
            this.tbxDuracionHoras.Name = "tbxDuracionHoras";
            this.tbxDuracionHoras.Size = new System.Drawing.Size(45, 26);
            this.tbxDuracionHoras.TabIndex = 13;
            this.tbxDuracionHoras.Text = "0";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(107, 68);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(225, 26);
            this.tbxNombre.TabIndex = 3;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(32, 268);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(86, 20);
            this.lblDuracion.TabIndex = 12;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(129, 100);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(203, 28);
            this.cbxCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(31, 103);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(92, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(155, 166);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(272, 90);
            this.tbxDescripcion.TabIndex = 9;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(32, 169);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(108, 20);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Descripción:";
            // 
            // nmCosto
            // 
            this.nmCosto.DecimalPlaces = 2;
            this.nmCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCosto.Location = new System.Drawing.Point(129, 134);
            this.nmCosto.Name = "nmCosto";
            this.nmCosto.Size = new System.Drawing.Size(120, 26);
            this.nmCosto.TabIndex = 11;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(31, 136);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(61, 20);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo:";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.cpFiltros);
            this.Controls.Add(this.cpBusquedas);
            this.Controls.Add(this.cpAccionesRapidas);
            this.Controls.Add(this.cpDatosServicio);
            this.Controls.Add(this.dgvServicios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.cpBusquedas.ResumeLayout(false);
            this.cpBusquedas.PerformLayout();
            this.gbBuscName.ResumeLayout(false);
            this.gbBuscName.PerformLayout();
            this.gbBuscCod.ResumeLayout(false);
            this.gbBuscCod.PerformLayout();
            this.cpAccionesRapidas.ResumeLayout(false);
            this.cpAccionesRapidas.PerformLayout();
            this.cpDatosServicio.ResumeLayout(false);
            this.cpDatosServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCosto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.NumericUpDown nmCosto;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.TextBox tbxDuracionMinutos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox tbxDuracionHoras;
        private System.Windows.Forms.DataGridView dgvServicios;
        private CustomPanel cpDatosServicio;
        private System.Windows.Forms.Label lblDatosServicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomButton btnAumentarTiempo;
        private System.Windows.Forms.Label lblAccionesRapidas;
        private CustomPanel cpAccionesRapidas;
        private CustomButton btnAgregar;
        private CustomButton btnEliminar;
        private CustomButton btnModificar;
        private CustomPanel cpBusquedas;
        private CustomButton btnBuscar;
        private System.Windows.Forms.Label lblBusquedas;
        private System.Windows.Forms.GroupBox gbBuscName;
        private System.Windows.Forms.TextBox tbxBuscNombre;
        private System.Windows.Forms.GroupBox gbBuscCod;
        private System.Windows.Forms.TextBox tbxBuscCodigo;
        private CustomPanel cpFiltros;
        private CustomButton btnLimpiarCampos;
    }
}