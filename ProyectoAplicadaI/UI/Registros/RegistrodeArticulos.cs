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
    public partial class RegistrodeArticulos : Form
    {
        public RegistrodeArticulos()
        {
            InitializeComponent();
        }

        private void RegistrodeArticulos_Load(object sender, EventArgs e)
        {
           

        }


        private bool validar(int error)
        {
            bool errores = false;
            int num = 0;
            if (error == 1 && articuloIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(articuloIdNumericUpDown, "Llenar Articulos Id");
                errores = true;
            }


            if (error == 2 && string.IsNullOrEmpty(nombreTextBox.Text))
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Llene Nombre");
                errores = true;
            }

            if (error == 3 && int.TryParse(nombreTextBox.Text, out num) == true)
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Debe Digitar Caracteres");
                errores = true;
            }

            return errores;

        }


        private void Limpiar()
        {
            articuloIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            inventarioTextBox.Clear();
            GeneralerrorProvider.Clear();
        }



        private Articulos Llenaclase()
        {
           Articulos articulos = new Articulos();

            inventarioTextBox.Text = 0.ToString();
            articulos.ArticuloId = Convert.ToInt32(articuloIdNumericUpDown.Value);
            articulos.Nombre = nombreTextBox.Text;
            articulos.Inventario = Convert.ToInt32(inventarioTextBox.Text);

            return articulos;
        }
      

       

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(articuloIdNumericUpDown.Value);

                if (BLL.ArticulosBLL.Eliminar(id))
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



        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(articuloIdNumericUpDown.Value);
               Articulos articulos = BLL.ArticulosBLL.Buscar(id);

                if (articulos != null)
                {
                    articuloIdNumericUpDown.Value = articulos.ArticuloId;
                    nombreTextBox.Text = articulos.Nombre;
                    inventarioTextBox.Text = articulos.Inventario.ToString();

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }
        }



        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulos = Llenaclase();
            int id = Convert.ToInt32(articuloIdNumericUpDown.Value);

            if (validar(3))
            {
                MessageBox.Show("Favor Dijite un Nombre");
                return;
            }
            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (articuloIdNumericUpDown.Value == 0)
                {
                    paso = BLL.ArticulosBLL.Guardar(articulos);
                }
                else
                {
         
                     var articulo = BLL.ArticulosBLL.Buscar(id);

                    if (articulo != null)
                    {
                        paso = BLL.ArticulosBLL.Editar(articulos);
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
    }
}
