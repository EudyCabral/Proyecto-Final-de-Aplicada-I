using ProyectoAplicadaI.UI.Cuenta;
using ProyectoAplicadaI.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoAplicadaI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeClientes clientes = new RegistrodeClientes();

            clientes.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeArticulos articulos = new RegistrodeArticulos();
            articulos.Show();
        }

       

        private void reciboDeEmpeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeRecibo recibo = new RegistrodeRecibo();
            recibo.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeUsuarios usuarios = new RegistrodeUsuarios();
            usuarios.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void entradaDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeEntradadeActivos entrada = new RegistrodeEntradadeActivos();
            entrada.Show();
        }

        private void capitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos capital = new Activos();
            capital.Show();

        }
    }
}
