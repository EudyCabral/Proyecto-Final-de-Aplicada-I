using BLL;
using DAL;
using ENTIDADES;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoAplicadaI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> usuarios = new Repositorio<Usuarios>(new Contexto());
          
            var Lista = usuarios.GetList(x => x.Usuario.Equals(UsuariotextBox.Text) && x.Contraseña.Equals(ClavetextBox.Text));
            Usuarios usuario = (Lista != null && Lista.Count > 0) ? Lista[0] : null;

            if (usuario != null)
            {
                foreach (var item in UsuariosBLL.GetList(x => x.Usuario == UsuariotextBox.Text))
                {
                    ReciboBLL.NombreLogin(item.Nombre,item.Tipodeusuario);
                }
                this.Hide();
                Thread hilo = new Thread(Menu);
                hilo.Start();

                return;
            }
            else
            {
                MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClavetextBox.Clear();
            }

        }

        private void Menu()
        {
            DataTable dt =new DataTable();
            Application.Run(new MainForm());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
