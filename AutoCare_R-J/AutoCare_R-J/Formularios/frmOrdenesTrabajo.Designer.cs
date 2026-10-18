using System.Drawing;
namespace AutoCare_R_J.Formularios
{
    partial class frmOrdenesTrabajo
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
            this.cpFiltros = new AutoCare_R_J.CustomPanel();
            this.cpBusquedas = new AutoCare_R_J.CustomPanel();
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tbxRepuestos = new System.Windows.Forms.TextBox();
            this.lnlRepuestos = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxVehiculo = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lnlVehiculo = new System.Windows.Forms.Label();
            this.cbxServicio = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.dtpFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFechaRecepcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDatosServicio = new System.Windows.Forms.Label();
            this.dgvOrdenesTrabajo = new System.Windows.Forms.DataGridView();
            this.cpBusquedas.SuspendLayout();
            this.gbBuscCod.SuspendLayout();
            this.cpAccionesRapidas.SuspendLayout();
            this.cpDatosServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // cpFiltros
            // 
            this.cpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.cpFiltros.BorderRadius = 20;
            this.cpFiltros.Location = new System.Drawing.Point(11, 336);
            this.cpFiltros.Name = "cpFiltros";
            this.cpFiltros.Size = new System.Drawing.Size(841, 70);
            this.cpFiltros.TabIndex = 36;
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
            this.cpBusquedas.TabIndex = 35;
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
            this.cpAccionesRapidas.Location = new System.Drawing.Point(469, 3);
            this.cpAccionesRapidas.Name = "cpAccionesRapidas";
            this.cpAccionesRapidas.Size = new System.Drawing.Size(383, 146);
            this.cpAccionesRapidas.TabIndex = 34;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.cpDatosServicio.Controls.Add(this.pictureBox6);
            this.cpDatosServicio.Controls.Add(this.tbxRepuestos);
            this.cpDatosServicio.Controls.Add(this.lnlRepuestos);
            this.cpDatosServicio.Controls.Add(this.cbxEstado);
            this.cpDatosServicio.Controls.Add(this.pictureBox5);
            this.cpDatosServicio.Controls.Add(this.label2);
            this.cpDatosServicio.Controls.Add(this.cbxVehiculo);
            this.cpDatosServicio.Controls.Add(this.pictureBox4);
            this.cpDatosServicio.Controls.Add(this.lnlVehiculo);
            this.cpDatosServicio.Controls.Add(this.cbxServicio);
            this.cpDatosServicio.Controls.Add(this.pictureBox3);
            this.cpDatosServicio.Controls.Add(this.lblServicio);
            this.cpDatosServicio.Controls.Add(this.dtpFechaRecepcion);
            this.cpDatosServicio.Controls.Add(this.pictureBox2);
            this.cpDatosServicio.Controls.Add(this.lblFechaRecepcion);
            this.cpDatosServicio.Controls.Add(this.pictureBox1);
            this.cpDatosServicio.Controls.Add(this.tbxCodigo);
            this.cpDatosServicio.Controls.Add(this.lblCodigo);
            this.cpDatosServicio.Controls.Add(this.lblDatosServicio);
            this.cpDatosServicio.Location = new System.Drawing.Point(11, 3);
            this.cpDatosServicio.Name = "cpDatosServicio";
            this.cpDatosServicio.Size = new System.Drawing.Size(452, 327);
            this.cpDatosServicio.TabIndex = 33;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AutoCare_R_J.Properties.Resources.escanear;
            this.pictureBox6.Location = new System.Drawing.Point(14, 200);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            // 
            // tbxRepuestos
            // 
            this.tbxRepuestos.Enabled = false;
            this.tbxRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRepuestos.Location = new System.Drawing.Point(148, 203);
            this.tbxRepuestos.Multiline = true;
            this.tbxRepuestos.Name = "tbxRepuestos";
            this.tbxRepuestos.Size = new System.Drawing.Size(272, 109);
            this.tbxRepuestos.TabIndex = 44;
            // 
            // lnlRepuestos
            // 
            this.lnlRepuestos.AutoSize = true;
            this.lnlRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlRepuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnlRepuestos.Location = new System.Drawing.Point(41, 206);
            this.lnlRepuestos.Name = "lnlRepuestos";
            this.lnlRepuestos.Size = new System.Drawing.Size(101, 20);
            this.lnlRepuestos.TabIndex = 43;
            this.lnlRepuestos.Text = "Repuestos:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Pendiente / Recepcionado",
            "En Diagnóstico / En Revisión",
            "En Proceso / En Reparación",
            "En Espera de Repuestos",
            "Finalizado / Listo para Entrega",
            "Entregado",
            "Cancelado"});
            this.cbxEstado.Location = new System.Drawing.Point(130, 167);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(290, 26);
            this.cbxEstado.TabIndex = 42;
            this.cbxEstado.UseWaitCursor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AutoCare_R_J.Properties.Resources.descripcion_del_trabajo;
            this.pictureBox5.Location = new System.Drawing.Point(14, 163);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(41, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Estado:";
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiculo.FormattingEnabled = true;
            this.cbxVehiculo.Location = new System.Drawing.Point(130, 133);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Size = new System.Drawing.Size(290, 26);
            this.cbxVehiculo.TabIndex = 39;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AutoCare_R_J.Properties.Resources.coche;
            this.pictureBox4.Location = new System.Drawing.Point(14, 129);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // lnlVehiculo
            // 
            this.lnlVehiculo.AutoSize = true;
            this.lnlVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnlVehiculo.Location = new System.Drawing.Point(41, 135);
            this.lnlVehiculo.Name = "lnlVehiculo";
            this.lnlVehiculo.Size = new System.Drawing.Size(83, 20);
            this.lnlVehiculo.TabIndex = 37;
            this.lnlVehiculo.Text = "Vehiculo:";
            // 
            // cbxServicio
            // 
            this.cbxServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServicio.FormattingEnabled = true;
            this.cbxServicio.Location = new System.Drawing.Point(130, 101);
            this.cbxServicio.Name = "cbxServicio";
            this.cbxServicio.Size = new System.Drawing.Size(290, 26);
            this.cbxServicio.TabIndex = 36;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AutoCare_R_J.Properties.Resources.servicio;
            this.pictureBox3.Location = new System.Drawing.Point(14, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServicio.Location = new System.Drawing.Point(41, 103);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(77, 20);
            this.lblServicio.TabIndex = 33;
            this.lblServicio.Text = "Servicio:";
            // 
            // dtpFechaRecepcion
            // 
            this.dtpFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecepcion.Location = new System.Drawing.Point(220, 70);
            this.dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            this.dtpFechaRecepcion.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaRecepcion.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoCare_R_J.Properties.Resources.calendario;
            this.pictureBox2.Location = new System.Drawing.Point(14, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // lblFechaRecepcion
            // 
            this.lblFechaRecepcion.AutoSize = true;
            this.lblFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRecepcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFechaRecepcion.Location = new System.Drawing.Point(41, 71);
            this.lblFechaRecepcion.Name = "lblFechaRecepcion";
            this.lblFechaRecepcion.Size = new System.Drawing.Size(172, 20);
            this.lblFechaRecepcion.TabIndex = 29;
            this.lblFechaRecepcion.Text = "Fecha de recepción:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCare_R_J.Properties.Resources.escanear;
            this.pictureBox1.Location = new System.Drawing.Point(14, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(117, 36);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(115, 26);
            this.tbxCodigo.TabIndex = 27;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.Location = new System.Drawing.Point(41, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 26;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDatosServicio
            // 
            this.lblDatosServicio.AutoSize = true;
            this.lblDatosServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosServicio.Location = new System.Drawing.Point(13, 9);
            this.lblDatosServicio.Name = "lblDatosServicio";
            this.lblDatosServicio.Size = new System.Drawing.Size(274, 24);
            this.lblDatosServicio.TabIndex = 25;
            this.lblDatosServicio.Text = "Datos de la orden de trabajo";
            // 
            // dgvOrdenesTrabajo
            // 
            this.dgvOrdenesTrabajo.AllowUserToAddRows = false;
            this.dgvOrdenesTrabajo.AllowUserToDeleteRows = false;
            this.dgvOrdenesTrabajo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrdenesTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesTrabajo.Location = new System.Drawing.Point(11, 412);
            this.dgvOrdenesTrabajo.MultiSelect = false;
            this.dgvOrdenesTrabajo.Name = "dgvOrdenesTrabajo";
            this.dgvOrdenesTrabajo.ReadOnly = true;
            this.dgvOrdenesTrabajo.Size = new System.Drawing.Size(841, 187);
            this.dgvOrdenesTrabajo.TabIndex = 32;
            // 
            // frmOrdenesTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.cpFiltros);
            this.Controls.Add(this.cpBusquedas);
            this.Controls.Add(this.cpAccionesRapidas);
            this.Controls.Add(this.cpDatosServicio);
            this.Controls.Add(this.dgvOrdenesTrabajo);
            this.Name = "frmOrdenesTrabajo";
            this.Text = "frmOrdenesTrabajo";
            this.cpBusquedas.ResumeLayout(false);
            this.cpBusquedas.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesTrabajo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel cpFiltros;
        private CustomPanel cpBusquedas;
        private System.Windows.Forms.GroupBox gbBuscCod;
        private System.Windows.Forms.TextBox tbxBuscCodigo;
        private CustomButton btnBuscar;
        private System.Windows.Forms.Label lblBusquedas;
        private CustomPanel cpAccionesRapidas;
        private CustomButton btnLimpiarCampos;
        private CustomButton btnEliminar;
        private CustomButton btnModificar;
        private CustomButton btnAgregar;
        private System.Windows.Forms.Label lblAccionesRapidas;
        private CustomPanel cpDatosServicio;
        private System.Windows.Forms.Label lblDatosServicio;
        private System.Windows.Forms.DataGridView dgvOrdenesTrabajo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcion;
        private System.Windows.Forms.ComboBox cbxVehiculo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lnlVehiculo;
        private System.Windows.Forms.ComboBox cbxServicio;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tbxRepuestos;
        private System.Windows.Forms.Label lnlRepuestos;
    }
}