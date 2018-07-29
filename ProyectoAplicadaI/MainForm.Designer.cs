namespace ProyectoAplicadaI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboDeEmpeñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empeñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasDeActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.TipodeUsuariolabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.cuentaToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.cobroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Windows8_32;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.archivoToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Exit_321;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Cancel_321;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitalToolStripMenuItem});
            this.cuentaToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Bank_32;
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // capitalToolStripMenuItem
            // 
            this.capitalToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Paper_Money_32;
            this.capitalToolStripMenuItem.Name = "capitalToolStripMenuItem";
            this.capitalToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.capitalToolStripMenuItem.Text = "Activos";
            this.capitalToolStripMenuItem.Click += new System.EventHandler(this.capitalToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.reciboDeEmpeñoToolStripMenuItem,
            this.registrarUsuarioToolStripMenuItem,
            this.entradaDeActivosToolStripMenuItem});
            this.registroToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Form_32;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.registroToolStripMenuItem.Text = "Registros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Person_32;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Washing_Machine_32;
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // reciboDeEmpeñoToolStripMenuItem
            // 
            this.reciboDeEmpeñoToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Receipt_32;
            this.reciboDeEmpeñoToolStripMenuItem.Name = "reciboDeEmpeñoToolStripMenuItem";
            this.reciboDeEmpeñoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.reciboDeEmpeñoToolStripMenuItem.Text = "Recibo de Empeño";
            this.reciboDeEmpeñoToolStripMenuItem.Click += new System.EventHandler(this.reciboDeEmpeñoToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Customer_32;
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // entradaDeActivosToolStripMenuItem
            // 
            this.entradaDeActivosToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Low_Price_32;
            this.entradaDeActivosToolStripMenuItem.Name = "entradaDeActivosToolStripMenuItem";
            this.entradaDeActivosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.entradaDeActivosToolStripMenuItem.Text = "Entrada de Activos";
            this.entradaDeActivosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeActivosToolStripMenuItem_Click);
            // 
            // cobroToolStripMenuItem
            // 
            this.cobroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrosDeArticulosToolStripMenuItem});
            this.cobroToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Cash_Register_32;
            this.cobroToolStripMenuItem.Name = "cobroToolStripMenuItem";
            this.cobroToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.cobroToolStripMenuItem.Text = "Cobros";
            // 
            // cobrosDeArticulosToolStripMenuItem
            // 
            this.cobrosDeArticulosToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Payment_History_32;
            this.cobrosDeArticulosToolStripMenuItem.Name = "cobrosDeArticulosToolStripMenuItem";
            this.cobrosDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cobrosDeArticulosToolStripMenuItem.Text = "Pago de Articulos Empeñados";
            this.cobrosDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.cobrosDeArticulosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.articulosToolStripMenuItem1,
            this.empeñoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.entradasDeActivoToolStripMenuItem,
            this.recibosToolStripMenuItem});
            this.consultaToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_View_32;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultaToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Person_32;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem1
            // 
            this.articulosToolStripMenuItem1.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Washing_Machine_32;
            this.articulosToolStripMenuItem1.Name = "articulosToolStripMenuItem1";
            this.articulosToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.articulosToolStripMenuItem1.Text = "Articulos";
            this.articulosToolStripMenuItem1.Click += new System.EventHandler(this.articulosToolStripMenuItem1_Click);
            // 
            // empeñoToolStripMenuItem
            // 
            this.empeñoToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Bill_32;
            this.empeñoToolStripMenuItem.Name = "empeñoToolStripMenuItem";
            this.empeñoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.empeñoToolStripMenuItem.Text = "Articulos Empeñados";
            this.empeñoToolStripMenuItem.Click += new System.EventHandler(this.empeñoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Customer_32;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // entradasDeActivoToolStripMenuItem
            // 
            this.entradasDeActivoToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Low_Price_32;
            this.entradasDeActivoToolStripMenuItem.Name = "entradasDeActivoToolStripMenuItem";
            this.entradasDeActivoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.entradasDeActivoToolStripMenuItem.Text = "Entradas de Activo";
            this.entradasDeActivoToolStripMenuItem.Click += new System.EventHandler(this.entradasDeActivoToolStripMenuItem_Click);
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Bill_322;
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.recibosToolStripMenuItem.Text = "Recibos";
            this.recibosToolStripMenuItem.Click += new System.EventHandler(this.recibosToolStripMenuItem_Click);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelabel.Location = new System.Drawing.Point(33, 24);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(63, 16);
            this.Nombrelabel.TabIndex = 1;
            this.Nombrelabel.Text = "Nombre";
            // 
            // TipodeUsuariolabel
            // 
            this.TipodeUsuariolabel.AutoSize = true;
            this.TipodeUsuariolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipodeUsuariolabel.Location = new System.Drawing.Point(33, 46);
            this.TipodeUsuariolabel.Name = "TipodeUsuariolabel";
            this.TipodeUsuariolabel.Size = new System.Drawing.Size(21, 13);
            this.TipodeUsuariolabel.TabIndex = 2;
            this.TipodeUsuariolabel.Text = "ad";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ProyectoAplicadaI.Properties.Resources.Casa_de_EMPENO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(512, 270);
            this.Controls.Add(this.TipodeUsuariolabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casa de Empeño";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboDeEmpeñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empeñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasDeActivoToolStripMenuItem;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label TipodeUsuariolabel;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
    }
}

