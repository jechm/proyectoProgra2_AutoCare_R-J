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
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.tbCtrlCintaDeOpciones.SuspendLayout();
            this.tbpConfiguracionYMantenimiento.SuspendLayout();
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
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = global::AutoCare_R_J.Properties.Resources.empleados;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.Location = new System.Drawing.Point(417, 3);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(100, 100);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.UseVisualStyleBackColor = true;
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
            // btnVehiculos
            // 
            this.btnVehiculos.BackgroundImage = global::AutoCare_R_J.Properties.Resources.vehiculos;
            this.btnVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVehiculos.Location = new System.Drawing.Point(106, 3);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(100, 100);
            this.btnVehiculos.TabIndex = 0;
            this.btnVehiculos.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.tbCtrlCintaDeOpciones.ResumeLayout(false);
            this.tbpConfiguracionYMantenimiento.ResumeLayout(false);
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
    }
}