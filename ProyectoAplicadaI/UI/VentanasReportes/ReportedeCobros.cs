
using ENTIDADES;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class ReportedeCobros : Form
    {
        List<Pagos> datos = new List<Pagos>();
        public ReportedeCobros(List<Pagos> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void ReportedeCobros_Load(object sender, EventArgs e)
        {
           
        }

        private void CobrosViewer_Load(object sender, EventArgs e)
        {
            Cobrosreport abrir = new Cobrosreport();
            abrir.SetDataSource(datos);
            CobrosViewer.ReportSource = abrir;
            CobrosViewer.Refresh();

        }
    }
}
