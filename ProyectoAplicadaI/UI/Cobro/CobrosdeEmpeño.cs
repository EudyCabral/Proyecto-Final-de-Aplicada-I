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

namespace ProyectoAplicadaI.UI.Cobro
{
    public partial class CobrosdeEmpeño : Form
    {
        public CobrosdeEmpeño()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Recibos, bool>> filtro = x => true;

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
                            filtro = x => x.ReciboId == id && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
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

                case 1://Nombre

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe un Nombre!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.NombredeCliente.Contains(CriteriotextBox.Text) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
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

                case 2:
                    filtro = x => true;
                    break;


            }

            if (FiltrocomboBox.SelectedItem != null)
            {
                CobrosdataGridView.DataSource = BLL.ReciboBLL.GetList(filtro);
                if (FiltrocomboBox.SelectedIndex == 0)
                {
                    foreach (var item in BLL.ReciboBLL.GetList(filtro))
                    {

                        deudatextBox.Text = quincenas(item.Fecha,item.MontoTotal).ToString();
                    }
                }
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
                CobrosdataGridView.Columns["Detalle"].Visible = false;
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

        private void CobrosdeEmpeño_Load(object sender, EventArgs e)
        {

        }


        private decimal quincenas(DateTime fecha, decimal monto)
        {
            
            decimal res = 0;
            var resultado = Math.Abs((fecha.Date - fechaActualDateTimePicker.Value.Date).TotalDays);

            if (resultado <= 15)
            {
                res = monto * Convert.ToDecimal(0.05);
                monto += res;
            }

            if (resultado >= 15 && resultado <= 30)
            {
                res = monto * Convert.ToDecimal(0.10);
                monto += res;
            }

            if (resultado >= 30 && resultado <= 45)
            {
                res = monto * Convert.ToDecimal(0.15);
                monto += res;
            }

            if (resultado >= 60 && resultado <= 75)
            {
                res = monto * Convert.ToDecimal(0.20);
                monto += res;
            }

            if (resultado == 75 && resultado <= 90)
            {
                res = monto * Convert.ToDecimal(0.25);
                monto += res;
            }

            if (resultado == 90 && resultado <= 95)
            {
                res = monto * Convert.ToDecimal(0.30);
                monto += res;
            }

            return monto;
        }
        public void NoColumnas()
        {
            CobrosdataGridView.Columns["ID"].Visible = false;
            //  DetalledataGridView.Columns["ReciboId"].Visible = false;
            CobrosdataGridView.Columns["ClienteId"].Visible = false;
            CobrosdataGridView.Columns["ArticuloId"].Visible = false;
            CobrosdataGridView.Columns["articulos"].Visible = false;


        }
        private void Abrirbutton_Click(object sender, EventArgs e)
        {


            Recibos recibo = new Recibos();
            if (CobrosdataGridView.Rows.Count > 0 && CobrosdataGridView.CurrentRow != null)
            {
                //convertir el grid en la lista
                List<Recibos> detalle = (List<Recibos>)CobrosdataGridView.DataSource;

                //selecciona la fila             
                int id = detalle.ElementAt(CobrosdataGridView.CurrentRow.Index).ReciboId;




                // Cargar el detalle al Grid
                CobrosdataGridView.DataSource = null;
                CobrosdataGridView.DataSource = BLL.ReciboDetallesBLL.GetList(x => x.ReciboId == id);
                foreach (var item in BLL.ReciboDetallesBLL.GetList(x => x.ReciboId == id))
                {

                    deudatextBox.Text = quincenas(item.FechadeEmpeño, detalle.ElementAt(CobrosdataGridView.CurrentRow.Index).MontoTotal).ToString();
                }
                NoColumnas();

                Abrirbutton.Enabled = false;

            }
        }
    }
}
