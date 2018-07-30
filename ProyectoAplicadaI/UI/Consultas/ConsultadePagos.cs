﻿using ProyectoAplicadaI.ENTIDADES;
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
    public partial class ConsultadePagos : Form
    {
        public ConsultadePagos()
        {
            InitializeComponent();
        }

        Expression<Func<Pagos, bool>> filtro = x => true;
        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            switch (FiltrocomboBox.SelectedIndex)
            {

                case 0://CobroId

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
                            filtro = x => x.PagosId == id && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.PagosId == id;
                        }




                        if (BLL.CobroBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;


                case 1:// ReciboId 

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

                        if (BLL.CobroBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://Abono

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
                        decimal abono = Convert.ToDecimal(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Abono == abono && (x.Fecha >= desdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                        }
                        else
                        {
                            filtro = x => x.Abono == abono;
                        }

                        if (BLL.CobroBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;



                case 3:// Monto
                    {
                        filtro = x => true;

                        if (BLL.CobroBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

            }

            if (FiltrocomboBox.SelectedItem != null)
            {
                CobrodataGridView.DataSource = BLL.CobroBLL.GetList(filtro);
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
                CobrodataGridView.Columns["ActivodeNegocioId"].Visible = false;
                


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
        private void ConsultadeCobros_Load(object sender, EventArgs e)
        {

        }

        private void Listabutton_Click(object sender, EventArgs e)
        {

            if (CobrodataGridView.DataSource != null)
            {
                ReportedeCobros abrir = new ReportedeCobros(BLL.CobroBLL.GetList(filtro));
                {
                    abrir.Show();
                }
            }
            else
            {
                MessageBox.Show("Grid esta Vacio, No puede hacer se un Reporte ", "Validacion");
                return;
            }
        }
    }
}
