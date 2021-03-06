﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller.Vista
{
    public partial class MdiAdministrador : Form
    {
        public MdiAdministrador()
        {
            InitializeComponent();
        }


        private void adicionarForm(Form form)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            adicionarForm(frmUsuario);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            adicionarForm(frmProducto);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            adicionarForm(frmCliente);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {


            FrmCuenta frmCuenta = new FrmCuenta();
            frmCuenta.cuentaUsuario = this.cuentaUsuario;
            adicionarForm(frmCuenta);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReportesAdministrador frmReportesAdministrador = new FrmReportesAdministrador();
            adicionarForm(frmReportesAdministrador);
        }
    }
}
