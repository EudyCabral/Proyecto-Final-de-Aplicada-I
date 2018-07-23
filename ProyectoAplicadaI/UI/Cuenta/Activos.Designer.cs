namespace ProyectoAplicadaI.UI.Cuenta
{
    partial class Activos
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
            System.Windows.Forms.Label capitalLabel;
            this.activolabel = new System.Windows.Forms.Label();
            capitalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // capitalLabel
            // 
            capitalLabel.AutoSize = true;
            capitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            capitalLabel.Location = new System.Drawing.Point(175, 61);
            capitalLabel.Name = "capitalLabel";
            capitalLabel.Size = new System.Drawing.Size(61, 24);
            capitalLabel.TabIndex = 1;
            capitalLabel.Text = "Activo";
            // 
            // activolabel
            // 
            this.activolabel.AutoSize = true;
            this.activolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activolabel.Location = new System.Drawing.Point(175, 85);
            this.activolabel.Name = "activolabel";
            this.activolabel.Size = new System.Drawing.Size(18, 20);
            this.activolabel.TabIndex = 3;
            this.activolabel.Text = "$";
            // 
            // Activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 182);
            this.Controls.Add(this.activolabel);
            this.Controls.Add(capitalLabel);
            this.Name = "Activos";
            this.Text = "Activo";
            this.Load += new System.EventHandler(this.Capital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label activolabel;
    }
}