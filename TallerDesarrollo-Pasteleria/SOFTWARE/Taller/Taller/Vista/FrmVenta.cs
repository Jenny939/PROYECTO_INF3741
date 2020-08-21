using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Taller.Modelo;
using Taller.Controlador;


namespace Taller.Vista
{
    public partial class FrmVenta : Form
    {
       
        ControladorCliente controladorCliente = new ControladorCliente();
        ControladorProducto controladorProducto = new ControladorProducto();
        ControladorDetalleProducto controladorDetalleProducto = new ControladorDetalleProducto();
        ControladorFactura controladorFactura= new ControladorFactura();



        public FrmVenta()
        {
            InitializeComponent();
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cliente oCliente;
            string ci;
            ci = txtCI.Text;

            oCliente=controladorCliente.buscarCI(ci);
            if (oCliente != null)
                txtCliente.Text = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;
            else
                MessageBox.Show("NO EXISTE EL CLIENTE");
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            FrmModificarCliente FrmCliente = new FrmModificarCliente();
            FrmCliente.ShowDialog();
            
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            
            dgProductos.DataSource = controladorProducto.refrescar();
          
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {

            det_producto oDetalleProducto = null;

            factura oFactura = new factura();
            cliente oCliente = null;
            

            usuario oUsuario = this.cuentaUsuario;

            string ci;
            ci = txtCI.Text;

            double total = 0;

            
            if (txtCliente.Text == "")
                MessageBox.Show("NECESARIO CI DEL CLIENTE PARA REALIZAR VENTA");
            
            else

            {
                oCliente = controladorCliente.buscarCI(ci);

               

                oFactura.nro = 99999;
                oFactura.id_cliente = oCliente.id;
                oFactura.id_usuario = oUsuario.id;
                oFactura.fecha = DateTime.Today;
                
                oFactura = controladorFactura.nuevo(oFactura);


                for (int i = 0; i < dgDetalle.RowCount - 1; i++)

                {
                    string t = dgDetalle.Rows[i].Cells[5].Value.ToString();
                    int id = System.Convert.ToInt16(dgDetalle.CurrentRow.Cells[0].Value);

                    total += Convert.ToDouble(dgDetalle.Rows[i].Cells[4].Value.ToString());

                  
                    if (string.Equals(t, "Producto"))
                    {
                        
                        oDetalleProducto = new det_producto();
                                              
                        oDetalleProducto.id_producto = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[0].Value);
                        oDetalleProducto.id_factura = oFactura.id;
                        oDetalleProducto.cantidad = System.Convert.ToInt16(dgDetalle.Rows[i].Cells[2].Value);
                        oDetalleProducto.precio_unitario = System.Convert.ToDouble (dgDetalle.Rows[i].Cells[3].Value);
                        oDetalleProducto.subtotal = System.Convert.ToDouble(dgDetalle.Rows[i].Cells[4].Value);

                        controladorDetalleProducto.nuevo(oDetalleProducto);
                                                
                    }

                }

                oFactura.total = total;
                controladorFactura.editar(oFactura);
                FrmFactura frmFactura = new FrmFactura();
                frmFactura.oFactura = oFactura;
                frmFactura.ShowDialog();
            }
            
            

        

        }

  
        private void btnAProd_Click(object sender, EventArgs e)
        {
            if (txtCantProd.Text == "")
                MessageBox.Show("ES NECESARIO INGRESAR UNA CANTIDAD");
            else
            {
                foreach (DataGridViewRow row in dgProductos.SelectedRows)
                {
                    string nombreProducto = dgProductos.CurrentRow.Cells[1].Value.ToString();

                    float precioProducto = System.Convert.ToSingle(dgProductos.CurrentRow.Cells[2].Value);
                    int cantidadProducto = System.Convert.ToInt16(txtCantProd.Text);

                    float subtotal = precioProducto * cantidadProducto;
                    int id = System.Convert.ToInt16(dgProductos.CurrentRow.Cells[0].Value);
                    dgDetalle.Rows.Add(id, nombreProducto, cantidadProducto, precioProducto, subtotal, "Producto");

                }
            }
                           
                       
        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtCantProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtCantServ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cmbRampa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
