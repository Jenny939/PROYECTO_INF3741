namespace Taller.Vista
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAProd = new System.Windows.Forms.Button();
            this.txtCantProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(259, 69);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 31);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCI
            // 
            this.txtCI.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCI.Location = new System.Drawing.Point(73, 69);
            this.txtCI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCI.MaxLength = 9;
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(170, 23);
            this.txtCI.TabIndex = 1;
            this.txtCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCI_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(73, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(25, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "CI:";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(415, 69);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(340, 23);
            this.txtCliente.TabIndex = 3;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.BackColor = System.Drawing.Color.White;
            this.btnCrearCliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.Location = new System.Drawing.Point(769, 69);
            this.btnCrearCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(119, 31);
            this.btnCrearCliente.TabIndex = 4;
            this.btnCrearCliente.Text = "NUEVO CLIENTE";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Location = new System.Drawing.Point(69, 122);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 219);
            this.tabControl1.TabIndex = 6;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.panel2);
            this.tabProductos.Controls.Add(this.dgProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 25);
            this.tabProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProductos.Size = new System.Drawing.Size(814, 190);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAProd);
            this.panel2.Controls.Add(this.txtCantProd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(696, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 182);
            this.panel2.TabIndex = 1;
            // 
            // btnAProd
            // 
            this.btnAProd.BackColor = System.Drawing.Color.White;
            this.btnAProd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAProd.Location = new System.Drawing.Point(17, 118);
            this.btnAProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAProd.Name = "btnAProd";
            this.btnAProd.Size = new System.Drawing.Size(85, 34);
            this.btnAProd.TabIndex = 2;
            this.btnAProd.Text = "AÑADIR";
            this.btnAProd.UseVisualStyleBackColor = false;
            this.btnAProd.Click += new System.EventHandler(this.btnAProd_Click);
            // 
            // txtCantProd
            // 
            this.txtCantProd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantProd.Location = new System.Drawing.Point(17, 50);
            this.txtCantProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantProd.MaxLength = 3;
            this.txtCantProd.Name = "txtCantProd";
            this.txtCantProd.Size = new System.Drawing.Size(85, 23);
            this.txtCantProd.TabIndex = 1;
            this.txtCantProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantProd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANTIDAD:";
            // 
            // dgProductos
            // 
            this.dgProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductos.Location = new System.Drawing.Point(3, 4);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(808, 182);
            this.dgProductos.TabIndex = 0;
            // 
            // dgDetalle
            // 
            this.dgDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.cantidad,
            this.precio,
            this.subtotal,
            this.tipo});
            this.dgDetalle.Location = new System.Drawing.Point(72, 359);
            this.dgDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.Size = new System.Drawing.Size(683, 116);
            this.dgDetalle.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRealizarVenta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.Location = new System.Drawing.Point(772, 359);
            this.btnRealizarVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(119, 47);
            this.btnRealizarVenta.TabIndex = 8;
            this.btnRealizarVenta.Text = "REALIZAR VENTA";
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelarVenta.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.Location = new System.Drawing.Point(772, 428);
            this.btnCancelarVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(119, 47);
            this.btnCancelarVenta.TabIndex = 9;
            this.btnCancelarVenta.Text = "CANCELAR";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(412, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE CLIENTE:";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAProd;
        private System.Windows.Forms.TextBox txtCantProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Label label3;

        public Taller.Modelo.usuario cuentaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}