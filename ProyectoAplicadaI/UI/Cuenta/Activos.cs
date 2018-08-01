using BLL;
using ENTIDADES;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Cuenta
{
    public partial class Activos : Form
    {
        public Activos()
        {
            InitializeComponent();
        }

        private void Capital_Load(object sender, EventArgs e)
        {
            ActivodeNegocio activodenegocio = ActivodeNegocioBLL.Buscar(1);
            activolabel.Text = 0.ToString();
            activolabel.Text = $"${activodenegocio.Activo.ToString()}";
            activolabel.ForeColor = Color.Green;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            ActivodeNegocio activodenegocio = ActivodeNegocioBLL.Buscar(1);
            activolabel.Text = 0.ToString();
            activolabel.Text = $"${activodenegocio.Activo.ToString()}";
            activolabel.ForeColor = Color.Green;
        }

     
    }
}
