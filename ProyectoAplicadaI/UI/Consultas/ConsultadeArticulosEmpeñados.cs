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
    public partial class ConsultadeArticulosEmpeñados : Form
    {
        public ConsultadeArticulosEmpeñados()
        {
            InitializeComponent();
        }

        Expression<Func<ReciboDetalles, bool>> filtro = x => true;
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
                       
                            filtro = x => x.ReciboId == id;
                     


                        if (BLL.ReciboDetallesBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

            
                case 1:// ArticuloId 

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
                        
                       
                            filtro = x => x.ArticuloId == id;
                     

                        if (BLL.ReciboDetallesBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case 2://NombreArticulo

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar un Nombre de Articulo!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                       
                            filtro = x => x.Articulo.Contains(CriteriotextBox.Text);
                       
                        if (BLL.ReciboDetallesBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

                case 3://Descripcion

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar una Direccion!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                       
                            filtro = x => x.Descripcion.Contains(CriteriotextBox.Text);
                        

                        if (BLL.ReciboDetallesBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

                case 4:// Cantidad

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
                        int cantidad = Convert.ToInt32(CriteriotextBox.Text);
                        

                    
                            filtro = x => x.Cantidad == cantidad;
                    
                        if (BLL.ReciboDetallesBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

                case 5:// Monto

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
                        

                            filtro = x => x.Monto == monto;
                 

                        if (BLL.ReciboDetallesBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

        
                case 6://TODO
                    filtro = x => true;

                    if (BLL.ReciboDetallesBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show("Lista esta Vacia, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }

            if (FiltrocomboBox.SelectedItem != null)
            {
               RecibodataGridView.DataSource = BLL.ReciboDetallesBLL.GetList(filtro);
                CriteriotextBox.Clear();
                GeneralerrorProvider.Clear();
                RecibodataGridView.Columns["articulos"].Visible = false;
                RecibodataGridView.Columns["ID"].Visible = false;
          

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
            if (RecibodataGridView.DataSource != null)
            {

                VentanaArticulosdelAlmacen abrir = new
                VentanaArticulosdelAlmacen(BLL.ReciboDetallesBLL.GetList(filtro));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Grid esta Vacio, No puede hacer se un Reporte ", "Validacion");
                return;
            }
        }
    }
}
