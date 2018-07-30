using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Registros
{
    public partial class RegistrodeUsuarios : Form
    {
        public RegistrodeUsuarios()
        {
            InitializeComponent();
        }

        private bool validar(int error)
        {
            bool errores = false;
            int num = 0;
            if (error == 1 && usuariosIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(usuariosIdNumericUpDown, "Llenar Usuario Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Llene Nombre");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(usuarioTextBox.Text))
            {
                GeneralerrorProvider.SetError(usuarioTextBox, "Llene Usuario");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(contraseñaTextBox.Text))
            {
                GeneralerrorProvider.SetError(contraseñaTextBox, "Llene contraseña");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(ConfirmartextBox.Text))
            {
                GeneralerrorProvider.SetError(ConfirmartextBox, "Llene contraseña");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(tipodeusuarioComboBox.Text))
            {
                GeneralerrorProvider.SetError(tipodeusuarioComboBox, "Llene Tipo de Usuario");
                errores = true;
            }
            if (error == 3 && int.TryParse(nombreTextBox.Text, out num) == true)
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Debe Digitar Caracteres");
                errores = true;
            }

            if (error == 4 && contraseñaTextBox.Text != ConfirmartextBox.Text)
            {
                GeneralerrorProvider.SetError(ConfirmartextBox, "Llenar Confirmar Contraseña");
                errores = true;
            }


            return errores;

        }

        private void Limpiar()
        {
            usuariosIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            usuarioTextBox.Clear();
            contraseñaTextBox.Clear();
            ConfirmartextBox.Clear();
            tipodeusuarioComboBox.SelectedItem = null;

            GeneralerrorProvider.Clear();
        }

        private Usuarios Llenaclase()
        {
            Usuarios usuarios = new Usuarios();


            usuarios.UsuariosId = Convert.ToInt32(usuariosIdNumericUpDown.Value);
            usuarios.Nombre = nombreTextBox.Text;
            usuarios.Usuario = usuarioTextBox.Text;
            usuarios.Contraseña = contraseñaTextBox.Text;
            usuarios.Tipodeusuario = tipodeusuarioComboBox.Text;

            return usuarios;
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);
                Usuarios usuarios = BLL.UsuariosBLL.Buscar(id);

                if (usuarios != null)
                {
                    usuariosIdNumericUpDown.Value = usuarios.UsuariosId;
                    nombreTextBox.Text = usuarios.Nombre;
                    usuarioTextBox.Text = usuarios.Usuario;
                    contraseñaTextBox.Text = usuarios.Contraseña;
                    tipodeusuarioComboBox.Text = usuarios.Tipodeusuario;

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }
        }

        private void RegistrodeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);

                if (BLL.UsuariosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Usuarios usuarios = Llenaclase();
            int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);

           

            if (validar(3))
            {
                MessageBox.Show("Favor Dijite un Nombre");
                return;
            }
            if (validar(4))
            {
                MessageBox.Show("La Contraseña no son Iguales","Validacion");
                contraseñaTextBox.Clear();
                ConfirmartextBox.Clear();
                return;
            }

            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (usuariosIdNumericUpDown.Value == 0)
                {
                    paso = BLL.UsuariosBLL.Guardar(usuarios);
                }
                else
                {

                    var usuario = BLL.UsuariosBLL.Buscar(id);

                    if (usuario != null)
                    {
                        paso = BLL.UsuariosBLL.Editar(usuarios);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Limpiar();
                GeneralerrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
