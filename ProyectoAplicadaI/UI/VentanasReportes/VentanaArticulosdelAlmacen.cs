using ENTIDADES;

using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.VentanasReportes
{
    public partial class VentanaArticulosdelAlmacen : Form
    {
        List<ReciboDetalles> datos = new List<ReciboDetalles>();
        public VentanaArticulosdelAlmacen(List<ReciboDetalles> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void AlmacenViewer_Load(object sender, EventArgs e)
        {
            ReportedeArticulosEmpeñados abrir = new ReportedeArticulosEmpeñados();
            abrir.SetDataSource(datos);
            AlmacenViewer.ReportSource = abrir;
            AlmacenViewer.Refresh();
           

        }
    }
}
