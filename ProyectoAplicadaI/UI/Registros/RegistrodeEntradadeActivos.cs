
using ENTIDADES;
using System;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Registros
{
    public partial class RegistrodeEntradadeActivos : Form
    {
        public RegistrodeEntradadeActivos()
        {
            InitializeComponent();
           
        }

        private void Limpiar()
        {
           entradadeActivosIdNumericUpDown.Value = 0;
           
            motivoTextBox.Clear();
            sumaTextBox.Clear();
            fechaDateTimePicker.Value = DateTime.Now;
         

            GeneralerrorProvider.Clear();
        }

       

        private bool validar(int error)
        {
            bool errores = false;
            decimal num = 0;
            if (error == 1 && entradadeActivosIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(entradadeActivosIdNumericUpDown, "Llenar Usuario Id");
                errores = true;
            }


            if (error == 2 && string.IsNullOrWhiteSpace(motivoTextBox.Text))
            {
                GeneralerrorProvider.SetError(motivoTextBox, "Llene Usuario");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(sumaTextBox.Text)  )
            {
                GeneralerrorProvider.SetError(sumaTextBox, "Llene contraseña");
                errores = true;
            }




           if (error == 3 && decimal.TryParse(sumaTextBox.Text, out num) == false)
            {
                GeneralerrorProvider.SetError(sumaTextBox, "Debe Digitar un monto");
                errores = true;
            }

            if (error == 4 && Convert.ToDecimal(sumaTextBox.Text) == 0)
            {
                GeneralerrorProvider.SetError(sumaTextBox, "Debe Digitar un monto");
                errores = true;
            }



            return errores;

        }

        private EntradadeActivos Llenaclase()
        {
           EntradadeActivos entradadeActivos = new EntradadeActivos();

            entradadeActivos.EntradadeActivosId = Convert.ToInt32(entradadeActivosIdNumericUpDown.Value);
            entradadeActivos.ActivodeNegocioId = 1;
            entradadeActivos.Fecha = fechaDateTimePicker.Value;
            entradadeActivos.Motivo = motivoTextBox.Text;
            entradadeActivos.Suma = Convert.ToDecimal(sumaTextBox.Text);
           

            return entradadeActivos;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           

            if (validar(3))
                    {
                        MessageBox.Show("Dijite un Monto");
                        return;
                    }

            if (validar(4))
            {
                MessageBox.Show("Dijite una Suma mayor que 0","Validar");
                return;
            }
            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
                return;
            }
        
            else
            {
                bool paso = false;


                EntradadeActivos entrada = Llenaclase();

                if (entradadeActivosIdNumericUpDown.Value == 0)
                {
                    paso = BLL.EntradadeActivosBLL.Guardar(entrada);
                }
                else
                {
                    int id = Convert.ToInt32(entradadeActivosIdNumericUpDown.Value);
                    var entry = BLL.EntradadeActivosBLL.Buscar(id);

                       if (entry != null)
                       {
                    paso = BLL.EntradadeActivosBLL.Editar(entrada);
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(entradadeActivosIdNumericUpDown.Value);
                EntradadeActivos entrada = BLL.EntradadeActivosBLL.Buscar(id);

                if (entrada != null)
                {
                   entradadeActivosIdNumericUpDown.Value = entrada.EntradadeActivosId;
                    fechaDateTimePicker.Value = entrada.Fecha;
                    motivoTextBox.Text = entrada.Motivo;
                    sumaTextBox.Text = entrada.Suma.ToString();

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
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(entradadeActivosIdNumericUpDown.Value);

                if (BLL.EntradadeActivosBLL.Eliminar(id))
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

        private void EntradadeActivos_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
