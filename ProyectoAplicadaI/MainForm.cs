using BLL;
using ENTIDADES;
using ProyectoAplicadaI.UI.Cobro;
using ProyectoAplicadaI.UI.Consultas;
using ProyectoAplicadaI.UI.Cuenta;
using ProyectoAplicadaI.UI.Registros;
using System;
using System.Windows.Forms;

namespace ProyectoAplicadaI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            usuarioToolStripMenuItem1.Text = ReciboBLL.returnUsuario().Nombre;
            tipoDeUsuarioToolStripMenuItem.Text = ReciboBLL.returnUsuario().Tipodeusuario;
        }
        

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeClientes clientes = new RegistrodeClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeArticulos articulos = new RegistrodeArticulos();
            articulos.MdiParent = this;
            articulos.Show();
        }

       

        private void reciboDeEmpeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeRecibo recibo = new RegistrodeRecibo();
            recibo.MdiParent = this; 
            recibo.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeUsuarios usuarios = new RegistrodeUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
              
            }
        }

        private void entradaDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeEntradadeActivos entrada = new RegistrodeEntradadeActivos();
            entrada.MdiParent = this;
            entrada.Show();
        }

        private void capitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos capital = new Activos();
            capital.MdiParent = this;
            capital.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeClientes clientes = new ConsultadeClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultadeArticulos articulos = new ConsultadeArticulos();
            articulos.MdiParent = this;
            articulos.Show();
        }

        private void empeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeArticulosEmpeñados recibos = new ConsultadeArticulosEmpeñados();
            recibos.MdiParent = this;
            recibos.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeUsuarios usuarios = new ConsultadeUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void entradasDeActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeEntradadeActivos activos = new ConsultadeEntradadeActivos();
            activos.MdiParent = this;
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
            RegistrodePago cobros =new RegistrodePago();
            cobros.MdiParent = this;
            cobros.Show();
        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeRecibos recibos = new ConsultadeRecibos();
            recibos.MdiParent = this;
            recibos.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadePagos consulta = new ConsultadePagos();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
