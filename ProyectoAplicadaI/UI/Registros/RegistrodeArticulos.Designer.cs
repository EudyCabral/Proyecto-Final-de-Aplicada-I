namespace ProyectoAplicadaI.UI.Registros
{
    partial class RegistrodeArticulos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articuloIdLabel;
            System.Windows.Forms.Label inventarioLabel;
            System.Windows.Forms.Label nombreLabel;
            this.articuloIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inventarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            articuloIdLabel = new System.Windows.Forms.Label();
            inventarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articuloIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // articuloIdLabel
            // 
            articuloIdLabel.AutoSize = true;
            articuloIdLabel.Location = new System.Drawing.Point(17, 14);
            articuloIdLabel.Name = "articuloIdLabel";
            articuloIdLabel.Size = new System.Drawing.Size(57, 13);
            articuloIdLabel.TabIndex = 1;
            articuloIdLabel.Text = "Articulo Id:";
            // 
            // inventarioLabel
            // 
            inventarioLabel.AutoSize = true;
            inventarioLabel.Location = new System.Drawing.Point(17, 97);
            inventarioLabel.Name = "inventarioLabel";
            inventarioLabel.Size = new System.Drawing.Size(57, 13);
            inventarioLabel.TabIndex = 3;
            inventarioLabel.Text = "Inventario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(17, 56);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // articuloIdNumericUpDown
            // 
            this.articuloIdNumericUpDown.Location = new System.Drawing.Point(80, 12);
            this.articuloIdNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.articuloIdNumericUpDown.Name = "articuloIdNumericUpDown";
            this.articuloIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.articuloIdNumericUpDown.TabIndex = 2;
            // 
            // inventarioTextBox
            // 
            this.inventarioTextBox.Location = new System.Drawing.Point(80, 92);
            this.inventarioTextBox.Name = "inventarioTextBox";
            this.inventarioTextBox.ReadOnly = true;
            this.inventarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventarioTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(80, 51);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(155, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(231, 147);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 18;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(125, 147);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 17;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(19, 147);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 16;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(231, 11);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // RegistrodeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 183);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(inventarioLabel);
            this.Controls.Add(this.inventarioTextBox);
            this.Controls.Add(articuloIdLabel);
            this.Controls.Add(this.articuloIdNumericUpDown);
            this.Name = "RegistrodeArticulos";
            this.Text = "RegistrodeArticulos";
            this.Load += new System.EventHandler(this.RegistrodeArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articuloIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown articuloIdNumericUpDown;
        private System.Windows.Forms.TextBox inventarioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
    }
}