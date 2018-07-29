using ProyectoAplicadaI.ENTIDADES;
using ProyectoAplicadaI.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
