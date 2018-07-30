namespace ProyectoAplicadaI.UI.VentanasReportes
{
    partial class ventanaEntradaReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaEntradaReportes));
            this.EntradaViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // EntradaViewer
            // 
            this.EntradaViewer.ActiveViewIndex = -1;
            this.EntradaViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntradaViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.EntradaViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntradaViewer.Location = new System.Drawing.Point(0, 0);
            this.EntradaViewer.Name = "EntradaViewer";
            this.EntradaViewer.Size = new System.Drawing.Size(800, 450);
            this.EntradaViewer.TabIndex = 0;
            this.EntradaViewer.Load += new System.EventHandler(this.EntradaViewer_Load);
            // 
            // ventanaEntradaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntradaViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaEntradaReportes";
            this.Text = "Reporte de Entrada ";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer EntradaViewer;
    }
}