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
    public partial class ClienteReporte : Form
    {
        List<Clientes> datos = new List<Clientes>();
        public ClienteReporte(List<Clientes> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void ClienteViewer_Load(object sender, EventArgs e)
        {
            RepoteClientes abrir = new RepoteClientes();
            abrir.SetDataSource(datos);
            ClienteViewer.ReportSource = abrir;
            ClienteViewer.Refresh();
        }
    }
}
