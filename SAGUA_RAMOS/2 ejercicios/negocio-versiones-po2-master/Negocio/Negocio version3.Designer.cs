namespace Negocio
{
    partial class Negocio_version3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.txtProductoVenta = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvClientes);
            this.tabPage1.Controls.Add(this.btnModificarCliente);
            this.tabPage1.Controls.Add(this.btnEliminarCliente);
            this.tabPage1.Controls.Add(this.btnAgregarCliente);
            this.tabPage1.Controls.Add(this.txtEmailCliente);
            this.tabPage1.Controls.Add(this.txtTelefonoCliente);
            this.tabPage1.Controls.Add(this.txtNombreCliente);
            this.tabPage1.Controls.Add(this.txtIdCliente);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 180);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(940, 266);
            this.dgvClientes.TabIndex = 11;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(446, 130);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnModificarCliente.TabIndex = 10;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(310, 130);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarCliente.TabIndex = 9;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(174, 130);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarCliente.TabIndex = 8;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(271, 100);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(250, 23);
            this.txtEmailCliente.TabIndex = 7;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(271, 70);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(250, 23);
            this.txtTelefonoCliente.TabIndex = 6;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(271, 40);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(250, 23);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(271, 10);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(250, 23);
            this.txtIdCliente.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvProductos);
            this.tabPage2.Controls.Add(this.btnModificarProducto);
            this.tabPage2.Controls.Add(this.btnEliminarProducto);
            this.tabPage2.Controls.Add(this.btnAgregarProducto);
            this.tabPage2.Controls.Add(this.txtPrecioProducto);
            this.tabPage2.Controls.Add(this.txtMarcaProducto);
            this.tabPage2.Controls.Add(this.txtNombreProducto);
            this.tabPage2.Controls.Add(this.txtCodigoProducto);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 180);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(940, 266);
            this.dgvProductos.TabIndex = 11;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(446, 130);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(100, 30);
            this.btnModificarProducto.TabIndex = 10;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(310, 130);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarProducto.TabIndex = 9;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(174, 130);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(271, 100);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(250, 23);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(271, 70);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(250, 23);
            this.txtMarcaProducto.TabIndex = 6;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(271, 40);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(250, 23);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(271, 10);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(250, 23);
            this.txtCodigoProducto.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Marca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Código";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvVentas);
            this.tabPage3.Controls.Add(this.btnModificarVenta);
            this.tabPage3.Controls.Add(this.btnEliminarVenta);
            this.tabPage3.Controls.Add(this.btnAgregarVenta);
            this.tabPage3.Controls.Add(this.txtTotalVenta);
            this.tabPage3.Controls.Add(this.txtCantidadVenta);
            this.tabPage3.Controls.Add(this.txtProductoVenta);
            this.tabPage3.Controls.Add(this.txtIdVenta);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(6, 180);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(940, 266);
            this.dgvVentas.TabIndex = 11;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // btnModificarVenta
            // 
            this.btnModificarVenta.Location = new System.Drawing.Point(446, 130);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(100, 30);
            this.btnModificarVenta.TabIndex = 10;
            this.btnModificarVenta.Text = "Modificar";
            this.btnModificarVenta.UseVisualStyleBackColor = true;
            this.btnModificarVenta.Click += new System.EventHandler(this.btnModificarVenta_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(310, 130);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarVenta.TabIndex = 9;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(174, 130);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarVenta.TabIndex = 8;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(271, 100);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(250, 23);
            this.txtTotalVenta.TabIndex = 7;
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(271, 70);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(250, 23);
            this.txtCantidadVenta.TabIndex = 6;
            // 
            // txtProductoVenta
            // 
            this.txtProductoVenta.Location = new System.Drawing.Point(271, 40);
            this.txtProductoVenta.Name = "txtProductoVenta";
            this.txtProductoVenta.Size = new System.Drawing.Size(250, 23);
            this.txtProductoVenta.TabIndex = 5;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(271, 10);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(250, 23);
            this.txtIdVenta.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cantidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Producto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(174, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimiento de Datos RETAIL";
            // 
            // Negocio_version3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Negocio_version3";
            this.Text = "Negocio_version3 - RETAIL";
            this.Load += new System.EventHandler(this.Negocio_version3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.TextBox txtProductoVenta;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
