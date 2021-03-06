﻿using ENTIDADES;
using System;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Registros
{
    public partial class RegistrodeClientes : Form
    {
        public RegistrodeClientes()
        {
            InitializeComponent();
        }

        private void RegistrodeClientes_Load(object sender, EventArgs e)
        {

        }

        private bool validar(int error)
        {
            bool errores = false;
            int num = 0;
            if (error == 1 && clienteIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(clienteIdNumericUpDown, "Llenar Cliente Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                GeneralerrorProvider.SetError(direccionTextBox, "Llene Direccion");
                errores = true;
            }
            
            if(error ==2 && cedulaMaskedTextBox.MaskFull == false)
            {

               GeneralerrorProvider.SetError(cedulaMaskedTextBox, "Completar los campos");

               errores = true;

            }

            if (error == 2 && telefonoMaskedTextBox.MaskFull == false)
            {

                GeneralerrorProvider.SetError(telefonoMaskedTextBox, "Completar los campos");

                errores = true;

            }

            if (error == 2 && string.IsNullOrWhiteSpace(cedulaMaskedTextBox.Text))
            {
                GeneralerrorProvider.SetError(cedulaMaskedTextBox, "Llene cedula");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(telefonoMaskedTextBox.Text))
            {
                GeneralerrorProvider.SetError(telefonoMaskedTextBox, "Llene telefono");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(nombreTextBox.Text))
            {
                GeneralerrorProvider.SetError(nombreTextBox, "Llene nombre");
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
            clienteIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            cedulaMaskedTextBox.Clear();
            direccionTextBox.Clear();
            telefonoMaskedTextBox.Clear();

            GeneralerrorProvider.Clear();
        }

        private Clientes Llenaclase()
        {
            Clientes clientes = new Clientes();


            clientes.ClienteId = Convert.ToInt32(clienteIdNumericUpDown.Value);
            clientes.Nombre = nombreTextBox.Text;
            clientes.Cedula = cedulaMaskedTextBox.Text;
            clientes.Direccion = direccionTextBox.Text;
            clientes.Telefono = telefonoMaskedTextBox.Text;

            return clientes;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Clientes clientes = Llenaclase();
            int id = Convert.ToInt32(clienteIdNumericUpDown.Value);

            if (validar(3))
            {
                MessageBox.Show("Favor Dijite un Nombre","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (clienteIdNumericUpDown.Value == 0)
                {
                    paso = BLL.ClienteBLL.Guardar(clientes);
                }
                else
                {

                    var cliente = BLL.ClienteBLL.Buscar(id);

                    if (cliente != null)
                    {
                        paso = BLL.ClienteBLL.Editar(clientes);
                    }
                    else
                    {
                        MessageBox.Show("Id no existe", "Falló",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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

            private void Buscarbutton_Click(object sender, EventArgs e)
            {
                if (validar(1))
                {
                    MessageBox.Show("Favor de Llenar Casilla para poder Buscar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {
                    int id = Convert.ToInt32(clienteIdNumericUpDown.Value);
                    Clientes clientes = BLL.ClienteBLL.Buscar(id);

                    if (clientes != null)
                    {
                       clienteIdNumericUpDown.Value = clientes.ClienteId;
                        nombreTextBox.Text = clientes.Nombre;
                        cedulaMaskedTextBox.Text = clientes.Cedula;
                        direccionTextBox.Text = clientes.Direccion;
                        telefonoMaskedTextBox.Text = clientes.Telefono;

                    }
                    else
                    {
                        MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GeneralerrorProvider.Clear();
                }
            }

            private void Eliminarbutton_Click(object sender, EventArgs e)
            {
                if (validar(1))
                {
                    MessageBox.Show("Favor de Llenar casilla para poder Eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {
                    int id = Convert.ToInt32(clienteIdNumericUpDown.Value);

                    if (BLL.ClienteBLL.Eliminar(id))
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

            private void Nuevobutton_Click(object sender, EventArgs e)
            {
                 Limpiar();
            }

       
    }   }
