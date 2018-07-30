using ProyectoAplicadaI.DAL;
using ProyectoAplicadaI.ENTIDADES;
using ProyectoAplicadaI.UI.VentanasReportes;
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
    public partial class RegistrodeRecibo : Form
    {
        public RegistrodeRecibo()
        {
            InitializeComponent();
            LlenaCombobox();

            nombrelabel.Text = $"{ BLL.ReciboBLL.returnUsuario().Tipodeusuario}: {BLL.ReciboBLL.returnUsuario().Nombre }";
       
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }

        private decimal ToDecimal(object valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor.ToString(), out retorno);
            return retorno;

        }

        private bool Validar(int error)
        {
            bool paso = false;

            decimal num=0;

            if (error == 1 && reciboIdNumericUpDown.Value == 0)
            {
                HayErrores.SetError(reciboIdNumericUpDown,
                   "No debes dejar la Recibo Id Vacio");
                paso = true;
            }
       
            

            if (error == 2 && DetalledataGridView.RowCount == 0)
            {
                HayErrores.SetError(DetalledataGridView,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            if (error == 4 && string.IsNullOrWhiteSpace(montoTextBox.Text))
            {
                HayErrores.SetError(montoTextBox,
                   "No debes dejar la Monto vacio");
                paso = true;
            }


            if (error == 4 && string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                HayErrores.SetError(descripcionTextBox,
                   "No debes dejar la descripcion vacia");
                paso = true;
            }
            if (error == 4 && cantidadNumericUpDown.Value == 0)
            {
                HayErrores.SetError(cantidadNumericUpDown,
                   "No debes dejar la Cantidad vacia");
                paso = true;
            }

            if (error == 3 && decimal.TryParse(montoTextBox.Text, out num) == false)
            {
                HayErrores.SetError(montoTextBox,
                   "Debe Dijitar un Monto");
                paso = true;
            }


            if (error == 5 && string.IsNullOrWhiteSpace(clienteIdComboBox.Text) || string.IsNullOrEmpty(articuloIdComboBox.Text))
            {
                HayErrores.SetError(clienteIdComboBox,
                   "No hay Cliente o Articulos Creado");
                paso = true;
            }


            if (error == 5 && string.IsNullOrEmpty(articuloIdComboBox.Text))
            {
                HayErrores.SetError(articuloIdComboBox,
                   "No hay Cliente o Articulos Creado");
                paso = true;
            }



            return paso;
        }

        public void NoColumnas()
        {
            DetalledataGridView.Columns["ID"].Visible = false;
            DetalledataGridView.Columns["ReciboId"].Visible = false;
            DetalledataGridView.Columns["ArticuloId"].Visible = false;
            DetalledataGridView.Columns["articulos"].Visible = false;

        
         }

        private void LlenaCombobox()
        {
            Repositorio<Clientes> clientes = new Repositorio<Clientes>(new Contexto());
            clienteIdComboBox.DataSource = clientes.GetList(c => true);
            clienteIdComboBox.ValueMember = "ClienteId";
            clienteIdComboBox.DisplayMember = "Nombre";

            Repositorio<Articulos> articulos = new Repositorio<Articulos>(new Contexto());
            articuloIdComboBox.DataSource = articulos.GetList(c => true);
            articuloIdComboBox.ValueMember = "ArticuloId";
            articuloIdComboBox.DisplayMember = "Nombre";
        }


        public void Limpiar()
        {
            reciboIdNumericUpDown.Value = 0;
            fechadeEmpeñoDateTimePicker.Value = DateTime.Now;
            fechaActualDateTimePicker.Value = DateTime.Now;
            cantidadNumericUpDown.Value = 0;
            descripcionTextBox.Clear();
            montoTextBox.Clear();
            montoTotalTextBox.Clear();
            DetalledataGridView.DataSource = null;
            Recibobutton.Enabled = false;
            HayErrores.Clear();
        }

        public void LimpiaRecibo()
        {
            fechadeEmpeñoDateTimePicker.Value = DateTime.Now;
            fechaActualDateTimePicker.Value = DateTime.Now;
            cantidadNumericUpDown.Value = 0;
            descripcionTextBox.Clear();
            montoTextBox.Clear();
            HayErrores.Clear();
        }
        


        private Recibos LlenaClase()
        {
            Recibos recibo = new Recibos();

            recibo.ReciboId = Convert.ToInt32(reciboIdNumericUpDown.Value);
            recibo.ClienteId = Convert.ToInt32(clienteIdComboBox.SelectedValue);
            recibo.NombredeCliente = BLL.ClienteBLL.RetornarNombre(clienteIdComboBox.Text);
            recibo.Fecha = fechadeEmpeñoDateTimePicker.Value;
            recibo.ActivodeNegocioId = 1;
            recibo.MontoTotal = Convert.ToDecimal(montoTotalTextBox.Text);
            recibo.Abono = 0;
            recibo.UltimaFechadeVigencia = fechadeEmpeñoDateTimePicker.Value.AddDays(95);



            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {

                recibo.AgregarDetalle
                    (ToInt(item.Cells["iD"].Value),
                     recibo.ReciboId,
                     ToInt(item.Cells["articuloId"].Value), 
                      Convert.ToString(item.Cells["articulo"].Value),
                      Convert.ToString(item.Cells["descripcion"].Value),
                       ToInt(item.Cells["cantidad"].Value),
                    ToDecimal(item.Cells["monto"].Value)




                  );
            }
            return recibo;
        }

        private void LlenaCampos(Recibos recibos)
        {

            reciboIdNumericUpDown.Value = recibos.ReciboId;
            fechadeEmpeñoDateTimePicker.Value = recibos.Fecha;
            clienteIdComboBox.Text = recibos.NombredeCliente;
            montoTotalTextBox.Text = recibos.MontoTotal.ToString();
            

            //Cargar el detalle al Grid
            DetalledataGridView.DataSource = recibos.Detalle;
            NoColumnas();

        }

        private void RegistrodeRecibo_Load(object sender, EventArgs e)
        {
            DateTime FechaAct = fechaActualDateTimePicker.Value;
            DateTime FechaEmpeño = fechadeEmpeñoDateTimePicker.Value.AddDays(90);
            if (FechaAct >= FechaEmpeño)
            {
                estadolabel.Text = "Vencido";
                estadolabel.ForeColor = Color.Red;
            }
            else
            {

                estadolabel.Text = "Vigente";
                estadolabel.ForeColor = Color.Green;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if(Validar(5))
            {
                MessageBox.Show(" Combobox Vacio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validar(4))
            {
                MessageBox.Show(" LLene las Casillas Correspondiente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            if (Validar(3))
            {
                MessageBox.Show(" Digite un Monto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            { 

                HayErrores.Clear();
                List<ReciboDetalles> detalle = new List<ReciboDetalles>();
                if (DetalledataGridView.DataSource != null)
                {
                    detalle = (List<ReciboDetalles>)DetalledataGridView.DataSource;
                }
          

                if (string.IsNullOrEmpty(montoTextBox.Text) && string.IsNullOrEmpty(cantidadNumericUpDown.Text))
                {
                    MessageBox.Show(" Llene cantidad y Monto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    detalle.Add(
                        new ReciboDetalles(iD: 0,
                        reciboId: (int)Convert.ToInt32(reciboIdNumericUpDown.Value),
                           articuloId: (int)articuloIdComboBox.SelectedValue,
                                articulo: (string)BLL.ArticulosBLL.RetornarNombre(articuloIdComboBox.Text),
                                descripcion: (string)descripcionTextBox.Text,
                            cantidad: (int)Convert.ToInt32(cantidadNumericUpDown.Value),
                            monto: (decimal)Convert.ToDecimal(montoTextBox.Text)


                        ));


                    //Cargar el detalle al Grid
                    DetalledataGridView.DataSource = null;
                    DetalledataGridView.DataSource = detalle;

                    decimal monto = 0;
                    foreach (var item in detalle)
                    {
                        monto += item.Monto;
                    }

                    montoTotalTextBox.Text = monto.ToString();

                 


                    //Oculta las Columnas No deceada
                    NoColumnas();
                    LimpiaRecibo();
                }
            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
           ReciboDetalles recibo = new ReciboDetalles();
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                //convertir el grid en la lista
                List<ReciboDetalles> detalle = (List<ReciboDetalles>)DetalledataGridView.DataSource;

                //remover la fila             
                detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                decimal monto = 0;

                foreach (var item in detalle)
                {
                    monto -= item.Monto;
                }

                monto *= (-1);
                montoTotalTextBox.Text = monto.ToString();


                // Cargar el detalle al Grid
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = detalle;


                NoColumnas();
            }
        }

        private void fechadeEmpeñoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaAct = fechaActualDateTimePicker.Value;
            DateTime FechaEmpeño = fechadeEmpeñoDateTimePicker.Value.AddDays(95);
            if (FechaAct >= FechaEmpeño)
            {
                estadolabel.Text = "Vencido";
                estadolabel.ForeColor = Color.Red;
            }
            else
            {

                estadolabel.Text = "Vigente";
                estadolabel.ForeColor = Color.Green;
            }
        }

       

        private void fechaActualDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaAct = fechaActualDateTimePicker.Value;
            DateTime FechaEmpeño = fechadeEmpeñoDateTimePicker.Value.AddDays(90);
            if (FechaAct >= FechaEmpeño)
            {
                estadolabel.Text = "Vencido";
                estadolabel.ForeColor = Color.Red;
            }
            else
            {

                estadolabel.Text = "Vigente";
                estadolabel.ForeColor = Color.Green;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (Validar(2))
            {
                MessageBox.Show("Debe Agregar Algun Producto al Grid", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (var item in BLL.ActivodeNegocioBLL.GetList(x => x.ActivodeNegocioId == 1))
                {

                    if (item.Activo < Convert.ToDecimal(montoTotalTextBox.Text))
                    {
                        MessageBox.Show("La Compraventa No dispone de Esa Cantidad de dinero ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Recibos recibos = LlenaClase();
                bool Paso = false;

                //Determinar si es Guardar o Modificar


                if (reciboIdNumericUpDown.Value == 0)
                {
                    Paso = BLL.ReciboBLL.Guardar(recibos);
                    HayErrores.Clear();
                }
                else
                {
                    var V = BLL.ReciboBLL.Buscar(Convert.ToInt32(reciboIdNumericUpDown.Value));

                    if (V != null)
                    {
                        Paso = BLL.ReciboBLL.Editar(recibos);
                    }
                    HayErrores.Clear();
                }



                //Informar el resultado
                if (Paso)
                {
                    
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Recibobutton.Enabled = true;
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {


                MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int id = Convert.ToInt32(reciboIdNumericUpDown.Value);
                if (BLL.ReciboBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(reciboIdNumericUpDown.Value);
            Recibos recibos = BLL.ReciboBLL.Buscar(id);

            if (recibos != null)
            {
                LlenaCampos(recibos);

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Recibobutton_Click(object sender, EventArgs e)
        {
            List<Recibos> list = BLL.ReciboBLL.GetList(X=> true);

            List<Recibos> nuevo = new List<Recibos>();

            nuevo.Add( list.Last()); 
            // return 
            VentanaReciboReporte abrir = new VentanaReciboReporte(nuevo);
            abrir.Show();


        }

      
    }
}
