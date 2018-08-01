
using ENTIDADES;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class VentanaReciboReporte : Form
    {
        List<Recibos> datos = new List<Recibos>();
   

        public VentanaReciboReporte(List<Recibos> list)
        {
            InitializeComponent();
            datos = list;
        }

      

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteRecibo abrir = new ReporteRecibo();
            abrir.SetDataSource(datos);
            ReciboViewer.ReportSource = abrir;
            ReciboViewer.Refresh();
        }
    }
}
