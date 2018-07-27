namespace ProyectoAplicadaI.UI.Registros
{
    partial class RegistrodeRecibo
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
            System.Windows.Forms.Label reciboIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label fechaVencimientoLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label articuloIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label montoTotalLabel;
            System.Windows.Forms.Label estadodelArticuloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodeRecibo));
            this.reciboIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechadeEmpeñoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaActualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.articuloIdComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.montoTotalTextBox = new System.Windows.Forms.TextBox();
            this.estadolabel = new System.Windows.Forms.Label();
            this.HayErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.nombrelabel = new System.Windows.Forms.Label();
            reciboIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            fechaVencimientoLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            articuloIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            montoTotalLabel = new System.Windows.Forms.Label();
            estadodelArticuloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reciboIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // reciboIdLabel
            // 
            reciboIdLabel.AutoSize = true;
            reciboIdLabel.Location = new System.Drawing.Point(6, 14);
            reciboIdLabel.Name = "reciboIdLabel";
            reciboIdLabel.Size = new System.Drawing.Size(56, 13);
            reciboIdLabel.TabIndex = 1;
            reciboIdLabel.Text = "Recibo Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(438, 61);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(100, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha de Empeño :";
            // 
            // fechaVencimientoLabel
            // 
            fechaVencimientoLabel.AutoSize = true;
            fechaVencimientoLabel.Location = new System.Drawing.Point(438, 35);
            fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            fechaVencimientoLabel.Size = new System.Drawing.Size(73, 13);
            fechaVencimientoLabel.TabIndex = 5;
            fechaVencimientoLabel.Text = "Fecha Actual:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(8, 65);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(54, 13);
            clienteIdLabel.TabIndex = 7;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // articuloIdLabel
            // 
            articuloIdLabel.AutoSize = true;
            articuloIdLabel.Location = new System.Drawing.Point(5, 124);
            articuloIdLabel.Name = "articuloIdLabel";
            articuloIdLabel.Size = new System.Drawing.Size(57, 13);
            articuloIdLabel.TabIndex = 9;
            articuloIdLabel.Text = "Articulo Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(242, 124);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 11;
            descripcionLabel.Text = "Descripcion:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(8, 178);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 13;
            cantidadLabel.Text = "Cantidad:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(253, 178);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 15;
            montoLabel.Text = "Monto:";
            // 
            // montoTotalLabel
            // 
            montoTotalLabel.AutoSize = true;
            montoTotalLabel.Location = new System.Drawing.Point(480, 454);
            montoTotalLabel.Name = "montoTotalLabel";
            montoTotalLabel.Size = new System.Drawing.Size(67, 13);
            montoTotalLabel.TabIndex = 20;
            montoTotalLabel.Text = "Monto Total:";
            // 
            // estadodelArticuloLabel
            // 
            estadodelArticuloLabel.AutoSize = true;
            estadodelArticuloLabel.Location = new System.Drawing.Point(438, 93);
            estadodelArticuloLabel.Name = "estadodelArticuloLabel";
            estadodelArticuloLabel.Size = new System.Drawing.Size(95, 13);
            estadodelArticuloLabel.TabIndex = 27;
            estadodelArticuloLabel.Text = "Estadodel Articulo:";
            // 
            // reciboIdNumericUpDown
            // 
            this.reciboIdNumericUpDown.Location = new System.Drawing.Point(68, 14);
            this.reciboIdNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.reciboIdNumericUpDown.Name = "reciboIdNumericUpDown";
            this.reciboIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.reciboIdNumericUpDown.TabIndex = 2;
            // 
            // fechadeEmpeñoDateTimePicker
            // 
            this.fechadeEmpeñoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechadeEmpeñoDateTimePicker.Location = new System.Drawing.Point(542, 57);
            this.fechadeEmpeñoDateTimePicker.Name = "fechadeEmpeñoDateTimePicker";
            this.fechadeEmpeñoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechadeEmpeñoDateTimePicker.TabIndex = 4;
            this.fechadeEmpeñoDateTimePicker.ValueChanged += new System.EventHandler(this.fechadeEmpeñoDateTimePicker_ValueChanged);
            // 
            // fechaActualDateTimePicker
            // 
            this.fechaActualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaActualDateTimePicker.Location = new System.Drawing.Point(542, 31);
            this.fechaActualDateTimePicker.Name = "fechaActualDateTimePicker";
            this.fechaActualDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaActualDateTimePicker.TabIndex = 6;
            this.fechaActualDateTimePicker.ValueChanged += new System.EventHandler(this.fechaActualDateTimePicker_ValueChanged);
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(68, 62);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(156, 21);
            this.clienteIdComboBox.TabIndex = 8;
            // 
            // articuloIdComboBox
            // 
            this.articuloIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articuloIdComboBox.FormattingEnabled = true;
            this.articuloIdComboBox.Location = new System.Drawing.Point(68, 121);
            this.articuloIdComboBox.Name = "articuloIdComboBox";
            this.articuloIdComboBox.Size = new System.Drawing.Size(156, 21);
            this.articuloIdComboBox.TabIndex = 10;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(314, 105);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(120, 50);
            this.descripcionTextBox.TabIndex = 12;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(66, 175);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNumericUpDown.TabIndex = 14;
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(312, 175);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(120, 20);
            this.montoTextBox.TabIndex = 16;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(9, 210);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.Size = new System.Drawing.Size(644, 235);
            this.DetalledataGridView.TabIndex = 17;
            // 
            // montoTotalTextBox
            // 
            this.montoTotalTextBox.Location = new System.Drawing.Point(553, 451);
            this.montoTotalTextBox.Name = "montoTotalTextBox";
            this.montoTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.montoTotalTextBox.TabIndex = 21;
            // 
            // estadolabel
            // 
            this.estadolabel.AutoSize = true;
            this.estadolabel.Location = new System.Drawing.Point(542, 95);
            this.estadolabel.Name = "estadolabel";
            this.estadolabel.Size = new System.Drawing.Size(0, 13);
            this.estadolabel.TabIndex = 31;
            // 
            // HayErrores
            // 
            this.HayErrores.ContainerControl = this;
            // 
            // Removerbutton
            // 
            this.Removerbutton.FlatAppearance.BorderSize = 0;
            this.Removerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removerbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Cancel_32;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(550, 166);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(89, 37);
            this.Removerbutton.TabIndex = 30;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.FlatAppearance.BorderSize = 0;
            this.Agregarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Plus_32;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(455, 166);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(89, 38);
            this.Agregarbutton.TabIndex = 29;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Delete_Document_321;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(312, 457);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 36);
            this.Eliminarbutton.TabIndex = 26;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Save_321;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(199, 457);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 36);
            this.Guardarbutton.TabIndex = 25;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Broom_321;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(86, 457);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 36);
            this.Nuevobutton.TabIndex = 24;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_View_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(194, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 40);
            this.Buscarbutton.TabIndex = 23;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // nombrelabel
            // 
            this.nombrelabel.AutoSize = true;
            this.nombrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrelabel.Location = new System.Drawing.Point(438, 9);
            this.nombrelabel.Name = "nombrelabel";
            this.nombrelabel.Size = new System.Drawing.Size(50, 13);
            this.nombrelabel.TabIndex = 32;
            this.nombrelabel.Text = "Nombre";
            // 
            // RegistrodeRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 504);
            this.Controls.Add(this.nombrelabel);
            this.Controls.Add(this.estadolabel);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(estadodelArticuloLabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(montoTotalLabel);
            this.Controls.Add(this.montoTotalTextBox);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(montoLabel);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(articuloIdLabel);
            this.Controls.Add(this.articuloIdComboBox);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdComboBox);
            this.Controls.Add(fechaVencimientoLabel);
            this.Controls.Add(this.fechaActualDateTimePicker);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechadeEmpeñoDateTimePicker);
            this.Controls.Add(reciboIdLabel);
            this.Controls.Add(this.reciboIdNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrodeRecibo";
            this.Text = "Registro de Recibo ";
            this.Load += new System.EventHandler(this.RegistrodeRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reciboIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown reciboIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker fechadeEmpeñoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaActualDateTimePicker;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.ComboBox articuloIdComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.TextBox montoTotalTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label estadolabel;
        private System.Windows.Forms.ErrorProvider HayErrores;
        private System.Windows.Forms.Label nombrelabel;
    }
}