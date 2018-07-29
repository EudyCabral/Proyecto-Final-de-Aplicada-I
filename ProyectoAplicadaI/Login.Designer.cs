namespace ProyectoAplicadaI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Iniciarbutton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(105, 145);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(100, 20);
            this.ClavetextBox.TabIndex = 9;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(105, 109);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(100, 20);
            this.UsuariotextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario :";
            // 
            // Iniciarbutton
            // 
            this.Iniciarbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Iniciarbutton.FlatAppearance.BorderSize = 0;
            this.Iniciarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Login32_32;
            this.Iniciarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Iniciarbutton.Location = new System.Drawing.Point(56, 182);
            this.Iniciarbutton.Name = "Iniciarbutton";
            this.Iniciarbutton.Size = new System.Drawing.Size(87, 37);
            this.Iniciarbutton.TabIndex = 10;
            this.Iniciarbutton.Text = "Iniciar ";
            this.Iniciarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Iniciarbutton.UseVisualStyleBackColor = true;
            this.Iniciarbutton.Click += new System.EventHandler(this.Iniciarbutton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::ProyectoAplicadaI.Properties.Resources.Login1;
            this.pictureBox.Location = new System.Drawing.Point(95, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(119, 91);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.FlatAppearance.BorderSize = 0;
            this.Cancelarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Cancel_32;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.Location = new System.Drawing.Point(165, 182);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(87, 37);
            this.Cancelarbutton.TabIndex = 11;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Iniciarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(311, 260);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Iniciarbutton);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iniciarbutton;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}