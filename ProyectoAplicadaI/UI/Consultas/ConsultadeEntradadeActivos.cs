using ENTIDADES;
using ProyectoAplicadaI.UI.VentanasReportes;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Consultas
{
    public partial class ConsultadeEntradadeActivos : Form
    {
        public ConsultadeEntradadeActivos()
        {
            InitializeComponent();
        }

        Expression<Func<EntradadeActivos, bool>> filtro = x => true;
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.EntradadeActivosId == id && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date); 
                        }
                        else
                        {
                            filtro = x => x.EntradadeActivosId == id;
                        }


                        if (BLL.EntradadeActivosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }


                    break;

                case 1://Motivo

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar Motivo!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                       

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Motivo.Contains(CriteriotextBox.Text) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.Motivo.Contains(CriteriotextBox.Text);
                        }



                        if (BLL.EntradadeActivosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://Suma

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        decimal suma = Convert.ToDecimal(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Suma == suma && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {

                            filtro = x => x.Suma== suma;
                        }

                        if (BLL.EntradadeActivosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

             

                case 3://Todo
                    filtro = x => true;
                    if (BLL.EntradadeActivosBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show(" Lista esta Vacia;", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;


            }

            if (FiltrocomboBox.SelectedItem != null)
            {
                EntradadataGridView.DataSource = BLL.EntradadeActivosBLL.GetList(filtro);
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
                EntradadataGridView.Columns["ActivodeNegocioId"].Visible = false;
            }
           




           
        
    }
        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            return paso;
        }
        private void ConsultadeEntradadeActivos_Load(object sender, EventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (EntradadataGridView.DataSource != null)
            {
                ventanaEntradaReportes abrir = new ventanaEntradaReportes(BLL.EntradadeActivosBLL.GetList(filtro));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Grid esta Vacio, No puede hacer se un Reporte ", "Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
