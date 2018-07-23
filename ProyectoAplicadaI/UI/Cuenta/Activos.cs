using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            ActivodeNegocio activodenegocio = BLL.ActivodeNegocioBLL.Buscar(1);
            activolabel.Text = 0.ToString();
            activolabel.Text = $"$ {activodenegocio.Activo.ToString()}";
            activolabel.ForeColor = Color.Green;
        }
    }
}
