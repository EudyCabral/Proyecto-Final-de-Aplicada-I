using ProyectoAplicadaI.ENTIDADES;
using ProyectoAplicadaI.UI.Cobro;
using ProyectoAplicadaI.UI.Consultas;
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
            Nombrelabel.Text = BLL.ReciboBLL.returnUsuario().Nombre;
            TipodeUsuariolabel.Text = BLL.ReciboBLL.returnUsuario().Tipodeusuario;
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeClientes clientes = new ConsultadeClientes();
            clientes.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultadeArticulos articulos = new ConsultadeArticulos();
            articulos.Show();
        }

        private void empeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeArticulosEmpeñados recibos = new ConsultadeArticulosEmpeñados();
            recibos.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeUsuarios usuarios = new ConsultadeUsuarios();
            usuarios.Show();
        }

        private void entradasDeActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeEntradadeActivos activos = new ConsultadeEntradadeActivos();
            activos.Show();
        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void cobrosDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CobrosdeEmpeño cobros =new CobrosdeEmpeño();
            cobros.Show();
        }
    }
}
