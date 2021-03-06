﻿namespace Taller.Vista
{
    partial class FrmReportesAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportesAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rdBtnTodo = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdBtnVendedor = new System.Windows.Forms.RadioButton();
            this.rdBtnFecha = new System.Windows.Forms.RadioButton();
            this.rdBtnVenFecha = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnListarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(329, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE ADMINISTRADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "OPERADOR: ";
            // 
            // cmbOperador
            // 
            this.cmbOperador.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(173, 295);
            this.cmbOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(171, 26);
            this.cmbOperador.TabIndex = 2;
            // 
            // dgReporte
            // 
            this.dgReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NroFactura,
            this.Cliente,
            this.Total});
            this.dgReporte.Location = new System.Drawing.Point(365, 121);
            this.dgReporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgReporte.MultiSelect = false;
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.ReadOnly = true;
            this.dgReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReporte.Size = new System.Drawing.Size(493, 329);
            this.dgReporte.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // NroFactura
            // 
            this.NroFactura.HeaderText = "NroFactura";
            this.NroFactura.Name = "NroFactura";
            this.NroFactura.ReadOnly = true;
            this.NroFactura.Width = 80;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 250;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.White;
            this.btnMostrar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(94, 406);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(250, 37);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "FACTURA";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rdBtnTodo
            // 
            this.rdBtnTodo.AutoSize = true;
            this.rdBtnTodo.Checked = true;
            this.rdBtnTodo.Location = new System.Drawing.Point(3, 4);
            this.rdBtnTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnTodo.Name = "rdBtnTodo";
            this.rdBtnTodo.Size = new System.Drawing.Size(59, 22);
            this.rdBtnTodo.TabIndex = 7;
            this.rdBtnTodo.TabStop = true;
            this.rdBtnTodo.Text = "TODO";
            this.rdBtnTodo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rdBtnVendedor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdBtnTodo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdBtnFecha, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdBtnVenFecha, 0, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(97, 117);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 123);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // rdBtnVendedor
            // 
            this.rdBtnVendedor.AutoSize = true;
            this.rdBtnVendedor.Location = new System.Drawing.Point(3, 64);
            this.rdBtnVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnVendedor.Name = "rdBtnVendedor";
            this.rdBtnVendedor.Size = new System.Drawing.Size(90, 22);
            this.rdBtnVendedor.TabIndex = 1;
            this.rdBtnVendedor.TabStop = true;
            this.rdBtnVendedor.Text = "VENDEDOR";
            this.rdBtnVendedor.UseVisualStyleBackColor = true;
            // 
            // rdBtnFecha
            // 
            this.rdBtnFecha.AutoSize = true;
            this.rdBtnFecha.Location = new System.Drawing.Point(3, 34);
            this.rdBtnFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnFecha.Name = "rdBtnFecha";
            this.rdBtnFecha.Size = new System.Drawing.Size(66, 22);
            this.rdBtnFecha.TabIndex = 0;
            this.rdBtnFecha.TabStop = true;
            this.rdBtnFecha.Text = "FECHA";
            this.rdBtnFecha.UseVisualStyleBackColor = true;
            // 
            // rdBtnVenFecha
            // 
            this.rdBtnVenFecha.AutoSize = true;
            this.rdBtnVenFecha.Location = new System.Drawing.Point(3, 94);
            this.rdBtnVenFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBtnVenFecha.Name = "rdBtnVenFecha";
            this.rdBtnVenFecha.Size = new System.Drawing.Size(147, 22);
            this.rdBtnVenFecha.TabIndex = 8;
            this.rdBtnVenFecha.TabStop = true;
            this.rdBtnVenFecha.Text = "VENDEDOR Y FECHA";
            this.rdBtnVenFecha.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 257);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.BackColor = System.Drawing.Color.White;
            this.btnListarVentas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarVentas.Location = new System.Drawing.Point(94, 353);
            this.btnListarVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Size = new System.Drawing.Size(250, 33);
            this.btnListarVentas.TabIndex = 10;
            this.btnListarVentas.Text = "LISTAR VENTAS";
            this.btnListarVentas.UseVisualStyleBackColor = false;
            this.btnListarVentas.Click += new System.EventHandler(this.btnListarVentas_Click);
            // 
            // FrmReportesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 544);
            this.Controls.Add(this.btnListarVentas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgReporte);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReportesAdministrador";
            this.Text = "FrmReportesAdministrador";
            this.Load += new System.EventHandler(this.FrmReportesAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RadioButton rdBtnTodo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdBtnVendedor;
        private System.Windows.Forms.RadioButton rdBtnFecha;
        private System.Windows.Forms.RadioButton rdBtnVenFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnListarVentas;
    }
}