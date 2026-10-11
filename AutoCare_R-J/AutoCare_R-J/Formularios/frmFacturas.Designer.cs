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
            this.cpBusquedas = new AutoCare_R_J.CustomPanel();
            this.gbBuscName = new System.Windows.Forms.GroupBox();
            this.tbxBuscNombre = new System.Windows.Forms.TextBox();
            this.gbBuscCod = new System.Windows.Forms.GroupBox();
            this.tbxBuscCodigo = new System.Windows.Forms.TextBox();
            this.lblBusquedas = new System.Windows.Forms.Label();
            this.cpAccionesRapidas = new AutoCare_R_J.CustomPanel();
            this.lblAccionesRapidas = new System.Windows.Forms.Label();
            this.customPanel1 = new AutoCare_R_J.CustomPanel();
            this.lblDatosServicio = new System.Windows.Forms.Label();
            this.cpFiltros = new AutoCare_R_J.CustomPanel();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new AutoCare_R_J.CustomButton();
            this.btnLimpiarCampos = new AutoCare_R_J.CustomButton();
            this.btnEliminar = new AutoCare_R_J.CustomButton();
            this.btnAgregar = new AutoCare_R_J.CustomButton();
            this.cpBusquedas.SuspendLayout();
            this.gbBuscName.SuspendLayout();
            this.gbBuscCod.SuspendLayout();
            this.cpAccionesRapidas.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // cpBusquedas
            // 
            this.cpBusquedas.BackColor = System.Drawing.Color.Transparent;
            this.cpBusquedas.BorderRadius = 20;
            this.cpBusquedas.Controls.Add(this.gbBuscName);
            this.cpBusquedas.Controls.Add(this.gbBuscCod);
            this.cpBusquedas.Controls.Add(this.btnBuscar);
            this.cpBusquedas.Controls.Add(this.lblBusquedas);
            this.cpBusquedas.Location = new System.Drawing.Point(469, 155);
            this.cpBusquedas.Name = "cpBusquedas";
            this.cpBusquedas.Size = new System.Drawing.Size(383, 175);
            this.cpBusquedas.TabIndex = 32;
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
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.Controls.Add(this.lblDatosServicio);
            this.customPanel1.Location = new System.Drawing.Point(12, 3);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(451, 327);
            this.customPanel1.TabIndex = 33;
            // 
            // lblDatosServicio
            // 
            this.lblDatosServicio.AutoSize = true;
            this.lblDatosServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosServicio.Location = new System.Drawing.Point(3, 6);
            this.lblDatosServicio.Name = "lblDatosServicio";
            this.lblDatosServicio.Size = new System.Drawing.Size(182, 24);
            this.lblDatosServicio.TabIndex = 26;
            this.lblDatosServicio.Text = "Datos de la factura";
            // 
            // cpFiltros
            // 
            this.cpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.cpFiltros.BorderRadius = 20;
            this.cpFiltros.Location = new System.Drawing.Point(11, 336);
            this.cpFiltros.Name = "cpFiltros";
            this.cpFiltros.Size = new System.Drawing.Size(841, 70);
            this.cpFiltros.TabIndex = 35;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(11, 412);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.Size = new System.Drawing.Size(841, 187);
            this.dgvServicios.TabIndex = 36;
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
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.cpFiltros);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.cpBusquedas);
            this.Controls.Add(this.cpAccionesRapidas);
            this.Name = "frmFacturas";
            this.Text = "Form1";
            this.cpBusquedas.ResumeLayout(false);
            this.cpBusquedas.PerformLayout();
            this.gbBuscName.ResumeLayout(false);
            this.gbBuscName.PerformLayout();
            this.gbBuscCod.ResumeLayout(false);
            this.gbBuscCod.PerformLayout();
            this.cpAccionesRapidas.ResumeLayout(false);
            this.cpAccionesRapidas.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel cpBusquedas;
        private System.Windows.Forms.GroupBox gbBuscName;
        private System.Windows.Forms.TextBox tbxBuscNombre;
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
        private System.Windows.Forms.DataGridView dgvServicios;
    }
}