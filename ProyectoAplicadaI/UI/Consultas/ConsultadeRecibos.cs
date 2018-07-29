using ProyectoAplicadaI.ENTIDADES;
using ProyectoAplicadaI.UI.VentanasReportes;
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
    public partial class ConsultadeRecibos : Form
    {
        public ConsultadeRecibos()
        {
            InitializeComponent();
        }
        Expression<Func<Recibos, bool>> filtro = x => true;
        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            switch (FiltrocomboBox.SelectedIndex)
            {

                case 0://ReciboId

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
                            filtro = x => x.ReciboId == id && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.ReciboId == id;
                        }




                        if (BLL.ReciboBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;


                case 1:// ClienteId 

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
                            filtro = x => x.ClienteId == id && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.ClienteId == id;
                        }

                        if (BLL.ReciboBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://NombredeCliente

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar un Nombre!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {


                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.NombredeCliente.Contains(CriteriotextBox.Text) && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.NombredeCliente.Contains(CriteriotextBox.Text);
                        }

                        if (BLL.ReciboBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

               

                case 3:// Monto

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Monto!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal monto = Convert.ToDecimal(CriteriotextBox.Text);


                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.MontoTotal == monto && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.MontoTotal== monto;
                        }

                        if (BLL.ReciboBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;


                case 6://TODO
                    filtro = x => true;

                    if (BLL.ReciboBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show("Lista esta Vacia, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }

            if (FiltrocomboBox.SelectedItem != null)
            {
                RecibodataGridView.DataSource = BLL.ReciboBLL.GetList(filtro);
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
                RecibodataGridView.Columns["ActivodeNegocioId"].Visible = false;
                RecibodataGridView.Columns["Detalle"].Visible = false;


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

            private void ConsultadeRecibos_Load(object sender, EventArgs e)
            {

            
            }

            private void Imprimirbutton_Click(object sender, EventArgs e)
            {
                Recibos recibo = new Recibos();
                if (RecibodataGridView.Rows.Count > 0 && RecibodataGridView.CurrentRow != null)
                {
                    //convertir el grid en la lista
                    List<Recibos> detalle = (List<Recibos>)RecibodataGridView.DataSource;

                    //selecciona la fila             
                    int id = detalle.ElementAt(RecibodataGridView.CurrentRow.Index).ReciboId;

                VentanaReciboReporte abrir = new VentanaReciboReporte(BLL.ReciboBLL.GetList(x => x.ReciboId == id));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("No Hay Nada dentro del Grid", "Validacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            }

        private void Listabutton_Click(object sender, EventArgs e)
        {
            if (RecibodataGridView.Rows.Count > 0 && RecibodataGridView.CurrentRow != null)
            {
                VentanadeListadeRecibo abrir = new VentanadeListadeRecibo(BLL.ReciboBLL.GetList(filtro));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("No Hay Nada dentro del Grid", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}
