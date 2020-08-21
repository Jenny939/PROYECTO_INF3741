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
    public partial class FrmFactura : Form
    {

        ControladorDetalleProducto controladorDetalleProducto = new ControladorDetalleProducto();
 
        ControladorFactura controladorFactura = new ControladorFactura();
        ControladorCliente controladorCliente = new ControladorCliente();
        ControladorProducto controladorProducto = new ControladorProducto();


        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            cliente oCliente;
            lblTotal.Text = lblTotal.Text + ": " + this.oFactura.total;

            oCliente = controladorCliente.buscarId(oFactura.id_cliente);

            
            lblCliente.Text = lblCliente.Text + ": " + oCliente.nombre;
            lblCliente.Text = lblCliente.Text + " " + oCliente.ap_paterno;
            lblCliente.Text = lblCliente.Text + " " + oCliente.ap_materno;

            lblNroFactura.Text = lblNroFactura.Text + ": " + this.oFactura.nro;

            lblFechaFactura.Text = lblFechaFactura.Text + ": " + this.oFactura.fecha.Day;
            lblFechaFactura.Text = lblFechaFactura.Text + "/" + this.oFactura.fecha.Month;
            lblFechaFactura.Text = lblFechaFactura.Text + "/" + this.oFactura.fecha.Year;

            List<det_producto> listaDetalleProducto = controladorDetalleProducto.listarPorFactura(this.oFactura.id);


            foreach (det_producto d in listaDetalleProducto)
            {
                producto prod = controladorProducto.buscarId(d.id_producto);
                dgFactura.Rows.Add(prod.nombre, d.cantidad, d.precio_unitario, d.subtotal);
            }

        }

        private void lblNroFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
