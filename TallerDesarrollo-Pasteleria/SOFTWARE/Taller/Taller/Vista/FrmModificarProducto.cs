﻿using System;
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
    public partial class FrmModificarProducto : Form
    {

        public int? id;
        producto oProducto = null;
        ControladorProducto controladorProducto = new ControladorProducto();

        public FrmModificarProducto(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }

        private void CargaDatos()
        {       
            oProducto = controladorProducto.buscarId(id);

            txtNombre.Text = oProducto.nombre;
            txtVenta.Text = Convert.ToString(oProducto.precio_venta);

            cBoxTipo.SelectedItem = oProducto.tipo;

            txtStock.Text = Convert.ToString(oProducto.stock);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                if (id == null)
                {
                    try
                    {
                        oProducto = new producto();

                        oProducto.nombre = txtNombre.Text;

                        oProducto.precio_venta = float.Parse(txtVenta.Text);

                        oProducto.tipo = Convert.ToString(cBoxTipo.SelectedItem);

                        oProducto.stock = Convert.ToInt32(txtStock.Text);


                        controladorProducto.nuevo(oProducto);
                        MessageBox.Show(this, "Producto Agregado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        oProducto.nombre = txtNombre.Text;


                        oProducto.precio_venta = float.Parse(txtVenta.Text);

                        oProducto.tipo = Convert.ToString(cBoxTipo.SelectedItem);

                        oProducto.stock = Convert.ToInt32(txtStock.Text);


                        controladorProducto.editar(oProducto);
                        MessageBox.Show(this, "Producto Modificado Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Error en el llenado del Formulario", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               // this.Close();
            }
            else
            {
                MessageBox.Show(this, "Error en el llenado del Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCampos(){
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingrese el Nombre del producto");
            }
           
            if(txtVenta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtVenta, "Ingrese el Valor de venta en Bs");
            }
            if(cBoxTipo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cBoxTipo, "Eliga un Tipo");
            }
            if(txtStock.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtStock, "Ingrese la Cantida Existente");
            }
           
         
            return ok;
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombre, "");

            errorProvider1.SetError(txtVenta, "");
            errorProvider1.SetError(cBoxTipo, "");
            errorProvider1.SetError(txtStock, "");


        }

       

        private void txtVenta_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtVenta.Text, out num))
            {
                errorProvider1.SetError(txtVenta, "Debe ser un valor Numerico");
            }
            else
            {
                errorProvider1.SetError(txtVenta, "");
            }
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtStock.Text, out num))
            {
                errorProvider1.SetError(txtStock, "Debe ser un valor Numerico");
            }
            else
            {
                errorProvider1.SetError(txtStock, "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
