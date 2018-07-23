using ProyectoAplicadaI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoAplicadaI.UI.Consultas
{
    public partial class ConsultadeEntradadeActivos : Form
    {
        public ConsultadeEntradadeActivos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<EntradadeActivos, bool>> filtro = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.EntradadeActivosId == id && (x.Fecha.Day >= DesdedateTimePicker.Value.Day) && (x.Fecha.Month >= DesdedateTimePicker.Value.Month) && (x.Fecha.Year >= DesdedateTimePicker.Value.Year) && (x.Fecha.Day <= HastadateTimePicker.Value.Day) && (x.Fecha.Month <= HastadateTimePicker.Value.Month) && (x.Fecha.Year <= HastadateTimePicker.Value.Year);
                           // filtro = x => x.EntradadeActivosId == id && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
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
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar Motivo!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                       

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Motivo.Contains(CriteriotextBox.Text) && (x.Fecha.Day >= DesdedateTimePicker.Value.Day) && (x.Fecha.Month >= DesdedateTimePicker.Value.Month) && (x.Fecha.Year >= DesdedateTimePicker.Value.Year) && (x.Fecha.Day <= HastadateTimePicker.Value.Day) && (x.Fecha.Month <= HastadateTimePicker.Value.Month) && (x.Fecha.Year <= HastadateTimePicker.Value.Year);
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
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal suma = Convert.ToDecimal(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Suma == suma && (x.Fecha.Day >= DesdedateTimePicker.Value.Day) && (x.Fecha.Month >= DesdedateTimePicker.Value.Month) && (x.Fecha.Year >= DesdedateTimePicker.Value.Year) && (x.Fecha.Day <= HastadateTimePicker.Value.Day) && (x.Fecha.Month <= HastadateTimePicker.Value.Month) && (x.Fecha.Year <= HastadateTimePicker.Value.Year);
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
    }
}
