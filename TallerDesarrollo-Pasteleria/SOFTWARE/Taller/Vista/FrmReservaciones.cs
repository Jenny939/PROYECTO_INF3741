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
    public partial class FrmReservaciones : Form
    {
        public FrmReservaciones()
        {
            InitializeComponent();
        }

        ControladorCliente controladorCliente = new ControladorCliente();
        ControladorProducto controladorProducto = new ControladorProducto();
        ControladorReservacion controladorReservacion = new ControladorReservacion();

        reservacion oReservacion = new reservacion();


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cliente oCliente;
            string ci;
            ci = txtCI.Text;

            oCliente = controladorCliente.buscarCI(ci);
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

        private void FrmReservaciones_Load(object sender, EventArgs e)
        {
            
            List<producto> listaProducto = controladorProducto.refrescar();
            foreach (producto r in listaProducto)
            {
                String ram = r.id + " - " + r.nombre;
                cmbRampa.Items.Add(ram);
            }
        }

        private void actualizar(DateTime fecha)
        {
            dgReservacion.Rows.Clear();

            List<reservacion> listaReservacion = controladorReservacion.listarPorFecha(fecha);

            foreach (reservacion r in listaReservacion)
            {
                cliente oCliente = controladorCliente.buscarId(r.id_cliente);
                string cliente = oCliente.nombre + " " + oCliente.ap_paterno + " " + oCliente.ap_materno;

                producto oProducto = controladorProducto.buscarId(r.id_producto);


                dgReservacion.Rows.Add(r.id, cliente, oProducto.nombre, r.horario, r.fecha, r.observacion);


            }
        }

        private void btnListarReservas_Click(object sender, EventArgs e)
        {
            
            DateTime fecha = dateTimePickerVerReservas.Value.Date;
            actualizar(fecha);            
            
        }
        


        private void btnReservar_Click(object sender, EventArgs e)
        {

            if (txtCliente.Text == "")
                MessageBox.Show("NECESARIO CI DEL CLIENTE PARA REALIZAR EL PEDIDO");
            if (cmbHora.Text=="")
                MessageBox.Show("NECESARIO SELECCIONAR UNA HORA");
            if (cmbRampa.Text=="")
                MessageBox.Show("NECESARIO SELECCIONAR UN PRODUCTO");
            else

            {

                cliente oCliente;
                oCliente = controladorCliente.buscarCI(txtCI.Text);

                
                string productinput = System.Convert.ToString(cmbRampa.SelectedItem);

                string rampadigits = new String(productinput.TakeWhile(Char.IsDigit).ToArray());

                string horario = "0." + cmbHora.SelectedItem.ToString();

                TimeSpan hora = TimeSpan.Parse(horario);

              


                oReservacion.id_cliente = oCliente.id;
                oReservacion.id_producto = System.Convert.ToInt16(rampadigits);
                oReservacion.horario = hora;
                oReservacion.fecha = dateTimePickerReservar.Value.Date;
                oReservacion.observacion = txtObservacion.Text;

                controladorReservacion.nuevo(oReservacion);
                MessageBox.Show(this, "Pedido Registrado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            DateTime fecha = dateTimePickerReservar.Value.Date;

            actualizar(fecha);
            
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgReservacion.Rows[dgReservacion.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                oReservacion = controladorReservacion.buscarId(id);
                oReservacion.observacion = "PEDIDO CANCELADO";
                controladorReservacion.editar(oReservacion);
                DateTime fecha = System.Convert.ToDateTime(oReservacion.fecha);
                actualizar(fecha);
            }

            
        }

        private void cmbRampa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
