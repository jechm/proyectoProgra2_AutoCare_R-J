namespace AutoCare_R_J.Formularios
{
    partial class frmVentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tbCtrlCintaDeOpciones = new System.Windows.Forms.TabControl();
            this.tbpConfiguracionYMantenimiento = new System.Windows.Forms.TabPage();
            this.tbpCitas = new System.Windows.Forms.TabPage();
            this.tbpConsultasYReportes = new System.Windows.Forms.TabPage();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.tbCtrlCintaDeOpciones.SuspendLayout();
            this.tbpConfiguracionYMantenimiento.SuspendLayout();
            this.tbpCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.tbCtrlCintaDeOpciones);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(929, 130);
            this.pnlMenu.TabIndex = 1;
            // 
            // tbCtrlCintaDeOpciones
            // 
            this.tbCtrlCintaDeOpciones.Controls.Add(this.tbpConfiguracionYMantenimiento);
            this.tbCtrlCintaDeOpciones.Controls.Add(this.tbpCitas);
            this.tbCtrlCintaDeOpciones.Controls.Add(this.tbpConsultasYReportes);
            this.tbCtrlCintaDeOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlCintaDeOpciones.Location = new System.Drawing.Point(0, 0);
            this.tbCtrlCintaDeOpciones.Name = "tbCtrlCintaDeOpciones";
            this.tbCtrlCintaDeOpciones.SelectedIndex = 0;
            this.tbCtrlCintaDeOpciones.Size = new System.Drawing.Size(929, 130);
            this.tbCtrlCintaDeOpciones.TabIndex = 0;
            // 
            // tbpConfiguracionYMantenimiento
            // 
            this.tbpConfiguracionYMantenimiento.Controls.Add(this.btnRepuestos);
            this.tbpConfiguracionYMantenimiento.Controls.Add(this.btnServicios);
            this.tbpConfiguracionYMantenimiento.Controls.Add(this.btnEmpleados);
            this.tbpConfiguracionYMantenimiento.Controls.Add(this.btnVehiculos);
            this.tbpConfiguracionYMantenimiento.Controls.Add(this.btnClientes);
            this.tbpConfiguracionYMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpConfiguracionYMantenimiento.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.tbpConfiguracionYMantenimiento.Name = "tbpConfiguracionYMantenimiento";
            this.tbpConfiguracionYMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConfiguracionYMantenimiento.Size = new System.Drawing.Size(921, 104);
            this.tbpConfiguracionYMantenimiento.TabIndex = 0;
            this.tbpConfiguracionYMantenimiento.Text = "Configuracion y Mantenimiento";
            this.tbpConfiguracionYMantenimiento.UseVisualStyleBackColor = true;
            // 
            // tbpCitas
            // 
            this.tbpCitas.Controls.Add(this.button1);
            this.tbpCitas.Location = new System.Drawing.Point(4, 22);
            this.tbpCitas.Name = "tbpCitas";
            this.tbpCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCitas.Size = new System.Drawing.Size(921, 104);
            this.tbpCitas.TabIndex = 1;
            this.tbpCitas.Text = "Transacciones";
            this.tbpCitas.UseVisualStyleBackColor = true;
            // 
            // tbpConsultasYReportes
            // 
            this.tbpConsultasYReportes.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultasYReportes.Name = "tbpConsultasYReportes";
            this.tbpConsultasYReportes.Size = new System.Drawing.Size(921, 104);
            this.tbpConsultasYReportes.TabIndex = 2;
            this.tbpConsultasYReportes.Text = "Consultas y Reportes";
            this.tbpConsultasYReportes.UseVisualStyleBackColor = true;
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.BackgroundImage = global::AutoCare_R_J.Properties.Resources.repuestos;
            this.btnRepuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRepuestos.Location = new System.Drawing.Point(313, 3);
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.Size = new System.Drawing.Size(100, 100);
            this.btnRepuestos.TabIndex = 1;
            this.btnRepuestos.UseVisualStyleBackColor = true;
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackgroundImage = global::AutoCare_R_J.Properties.Resources.servicios;
            this.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServicios.Location = new System.Drawing.Point(210, 3);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(100, 100);
            this.btnServicios.TabIndex = 1;
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = global::AutoCare_R_J.Properties.Resources.empleados;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.Location = new System.Drawing.Point(417, 3);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(100, 100);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackgroundImage = global::AutoCare_R_J.Properties.Resources.vehiculos;
            this.btnVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVehiculos.Location = new System.Drawing.Point(106, 3);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(100, 100);
            this.btnVehiculos.TabIndex = 0;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::AutoCare_R_J.Properties.Resources.clientes;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.Location = new System.Drawing.Point(3, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 100);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // button1
            // 
/*<<<<<<< HEAD
            this.button1.BackgroundImage = global::AutoCare_R_J.Properties.Resources.Botón_de_Facturas_Aprobadas1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
=======*/
            this.tbpCitas.Controls.Add(this.btnFacturas);
            this.tbpCitas.Controls.Add(this.btnOrdenesDeTrabajo);
            this.tbpCitas.Controls.Add(this.btnCitas);
            this.tbpCitas.Location = new System.Drawing.Point(4, 22);
            this.tbpCitas.Name = "tbpCitas";
            this.tbpCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCitas.Size = new System.Drawing.Size(921, 104);
            this.tbpCitas.TabIndex = 1;
            this.tbpCitas.Text = "Transacciones";
            this.tbpCitas.UseVisualStyleBackColor = true;
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackgroundImage = global::AutoCare_R_J.Properties.Resources.facturacion;
            this.btnFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturas.Location = new System.Drawing.Point(209, 2);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(100, 100);
            this.btnFacturas.TabIndex = 2;
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnOrdenesDeTrabajo
            // 
            this.btnOrdenesDeTrabajo.BackgroundImage = global::AutoCare_R_J.Properties.Resources.ordenes;
            this.btnOrdenesDeTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrdenesDeTrabajo.Location = new System.Drawing.Point(106, 2);
            this.btnOrdenesDeTrabajo.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenesDeTrabajo.Name = "btnOrdenesDeTrabajo";
            this.btnOrdenesDeTrabajo.Size = new System.Drawing.Size(100, 100);
            this.btnOrdenesDeTrabajo.TabIndex = 1;
            this.btnOrdenesDeTrabajo.UseVisualStyleBackColor = true;
            this.btnOrdenesDeTrabajo.Click += new System.EventHandler(this.btnOrdenesDeTrabajo_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackgroundImage = global::AutoCare_R_J.Properties.Resources.citas;
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCitas.Location = new System.Drawing.Point(2, 2);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(100, 100);
            this.btnCitas.TabIndex = 0;
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // tbpConsultasYReportes
            // 
            this.tbpConsultasYReportes.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultasYReportes.Name = "tbpConsultasYReportes";
            this.tbpConsultasYReportes.Size = new System.Drawing.Size(921, 104);
            this.tbpConsultasYReportes.TabIndex = 2;
            this.tbpConsultasYReportes.Text = "Consultas y Reportes";
            this.tbpConsultasYReportes.UseVisualStyleBackColor = true;
//>>>>>>> Formularios/Emilio
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 574);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCare R-J";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.tbCtrlCintaDeOpciones.ResumeLayout(false);
            this.tbpConfiguracionYMantenimiento.ResumeLayout(false);
            this.tbpCitas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TabControl tbCtrlCintaDeOpciones;
        private System.Windows.Forms.TabPage tbpConfiguracionYMantenimiento;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TabPage tbpCitas;
        private System.Windows.Forms.TabPage tbpConsultasYReportes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnRepuestos;
        private System.Windows.Forms.Button button1;
    }
}