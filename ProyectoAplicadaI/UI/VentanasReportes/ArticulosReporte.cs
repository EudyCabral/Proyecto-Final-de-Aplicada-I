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
    public partial class ArticulosReporte : Form
    {
        List<Articulos> datos = new List<Articulos>();
        public ArticulosReporte(List<Articulos> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void ArticulosViewer_Load(object sender, EventArgs e)
        {
            ReporteArticulos abrir = new ReporteArticulos();
            abrir.SetDataSource(datos);
            ArticulosViewer.ReportSource = abrir;
            ArticulosViewer.Refresh();
        }
    }
}
