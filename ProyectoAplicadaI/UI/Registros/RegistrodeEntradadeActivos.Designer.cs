namespace ProyectoAplicadaI.UI.Registros
{
    partial class RegistrodeEntradadeActivos
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
            System.Windows.Forms.Label entradadeActivosIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label motivoLabel;
            System.Windows.Forms.Label sumaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodeEntradadeActivos));
            this.entradadeActivosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.sumaTextBox = new System.Windows.Forms.TextBox();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            entradadeActivosIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            motivoLabel = new System.Windows.Forms.Label();
            sumaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entradadeActivosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // entradadeActivosIdLabel
            // 
            entradadeActivosIdLabel.AutoSize = true;
            entradadeActivosIdLabel.Location = new System.Drawing.Point(15, 16);
            entradadeActivosIdLabel.Name = "entradadeActivosIdLabel";
            entradadeActivosIdLabel.Size = new System.Drawing.Size(109, 13);
            entradadeActivosIdLabel.TabIndex = 8;
            entradadeActivosIdLabel.Text = "Entradade Activos Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(16, 52);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(14, 86);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(42, 13);
            motivoLabel.TabIndex = 10;
            motivoLabel.Text = "Motivo:";
            // 
            // sumaLabel
            // 
            sumaLabel.AutoSize = true;
            sumaLabel.Location = new System.Drawing.Point(14, 122);
            sumaLabel.Name = "sumaLabel";
            sumaLabel.Size = new System.Drawing.Size(37, 13);
            sumaLabel.TabIndex = 11;
            sumaLabel.Text = "Suma:";
            // 
            // entradadeActivosIdNumericUpDown
            // 
            this.entradadeActivosIdNumericUpDown.Location = new System.Drawing.Point(130, 12);
            this.entradadeActivosIdNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.entradadeActivosIdNumericUpDown.Name = "entradadeActivosIdNumericUpDown";
            this.entradadeActivosIdNumericUpDown.Size = new System.Drawing.Size(123, 20);
            this.entradadeActivosIdNumericUpDown.TabIndex = 0;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(130, 48);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.fechaDateTimePicker.TabIndex = 1;
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.Location = new System.Drawing.Point(129, 83);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(124, 20);
            this.motivoTextBox.TabIndex = 2;
            // 
            // sumaTextBox
            // 
            this.sumaTextBox.Location = new System.Drawing.Point(129, 118);
            this.sumaTextBox.Name = "sumaTextBox";
            this.sumaTextBox.Size = new System.Drawing.Size(124, 20);
            this.sumaTextBox.TabIndex = 3;
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            this.GeneralerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("GeneralerrorProvider.Icon")));
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Delete_Document_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(226, 157);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 34);
            this.Eliminarbutton.TabIndex = 7;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(120, 157);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(81, 34);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Broom_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(14, 157);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 34);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_View_321;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(259, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 40);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistrodeEntradadeActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(363, 204);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(sumaLabel);
            this.Controls.Add(this.sumaTextBox);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.motivoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(entradadeActivosIdLabel);
            this.Controls.Add(this.entradadeActivosIdNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrodeEntradadeActivos";
            this.Text = "Entrada de Activos";
            this.Load += new System.EventHandler(this.EntradadeActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entradadeActivosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown entradadeActivosIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.TextBox sumaTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
    }
}