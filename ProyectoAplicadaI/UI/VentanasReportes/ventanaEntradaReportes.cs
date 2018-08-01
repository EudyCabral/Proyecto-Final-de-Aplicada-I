using ENTIDADES;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class ventanaEntradaReportes : Form
    {
        List<EntradadeActivos> datos = new List<EntradadeActivos>();
        public ventanaEntradaReportes(List<EntradadeActivos> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void EntradaViewer_Load(object sender, EventArgs e)
        {
            ReporteEntradadeActivo abrir = new ReporteEntradadeActivo();
            abrir.SetDataSource(datos);
            EntradaViewer.ReportSource = abrir;
            EntradaViewer.Refresh();
        }
    }
}
