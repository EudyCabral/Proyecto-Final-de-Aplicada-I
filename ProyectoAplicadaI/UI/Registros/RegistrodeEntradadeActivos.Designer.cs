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
            this.entradadeActivosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.sumaTextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            entradadeActivosIdLabel.TabIndex = 1;
            entradadeActivosIdLabel.Text = "Entradade Activos Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(16, 52);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(14, 86);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(42, 13);
            motivoLabel.TabIndex = 7;
            motivoLabel.Text = "Motivo:";
            // 
            // sumaLabel
            // 
            sumaLabel.AutoSize = true;
            sumaLabel.Location = new System.Drawing.Point(14, 122);
            sumaLabel.Name = "sumaLabel";
            sumaLabel.Size = new System.Drawing.Size(37, 13);
            sumaLabel.TabIndex = 9;
            sumaLabel.Text = "Suma:";
            // 
            // entradadeActivosIdNumericUpDown
            // 
            this.entradadeActivosIdNumericUpDown.Location = new System.Drawing.Point(130, 12);
            this.entradadeActivosIdNumericUpDown.Name = "entradadeActivosIdNumericUpDown";
            this.entradadeActivosIdNumericUpDown.Size = new System.Drawing.Size(123, 20);
            this.entradadeActivosIdNumericUpDown.TabIndex = 2;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(130, 48);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.fechaDateTimePicker.TabIndex = 4;
            // 
            // motivoTextBox
            // 
            this.motivoTextBox.Location = new System.Drawing.Point(129, 83);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(124, 20);
            this.motivoTextBox.TabIndex = 8;
            // 
            // sumaTextBox
            // 
            this.sumaTextBox.Location = new System.Drawing.Point(129, 118);
            this.sumaTextBox.Name = "sumaTextBox";
            this.sumaTextBox.Size = new System.Drawing.Size(124, 20);
            this.sumaTextBox.TabIndex = 10;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(226, 168);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(120, 168);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(14, 168);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 20;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(276, 9);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 19;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // RegistrodeEntradadeActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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