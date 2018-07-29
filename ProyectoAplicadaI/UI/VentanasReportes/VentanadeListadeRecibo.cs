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
    public partial class VentanadeListadeRecibo : Form
    {
        List<Recibos> datos = new List<Recibos>();
        public VentanadeListadeRecibo(List<Recibos> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void VentanadeLista_de_Recibo_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadeRecibos abrir = new ListadeRecibos();
            abrir.SetDataSource(datos);
            ReciboViewer.ReportSource = abrir;
            ReciboViewer.Refresh();
        }
    }
}
