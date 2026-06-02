namespace linQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.txtBuscarP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.btnVerFicha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCategoriaP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarcaP = new System.Windows.Forms.TextBox();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOriginal
            // 
            this.lstOriginal.FormattingEnabled = true;
            this.lstOriginal.Items.AddRange(new object[] {
            "ELECTRONICA",
            "COMPUTADORAS",
            "PERIFERICOS",
            "ALMACENAMIENTO",
            "AUDIO Y VIDEO ",
            "HOGAR",
            "OFICINA",
            "ACCESORIOS"});
            this.lstOriginal.Location = new System.Drawing.Point(12, 82);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(120, 329);
            this.lstOriginal.TabIndex = 0;
            this.lstOriginal.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(285, 82);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(131, 20);
            this.txtBuscarP.TabIndex = 1;
            this.txtBuscarP.TextChanged += new System.EventHandler(this.txtBuscarP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR PRODUCTO: ";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(161, 118);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(519, 150);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(316, 310);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(100, 20);
            this.txtNombreP.TabIndex = 4;
            // 
            // btnVerFicha
            // 
            this.btnVerFicha.Location = new System.Drawing.Point(605, 309);
            this.btnVerFicha.Name = "btnVerFicha";
            this.btnVerFicha.Size = new System.Drawing.Size(75, 23);
            this.btnVerFicha.TabIndex = 5;
            this.btnVerFicha.Text = "Ver Ficha :";
            this.btnVerFicha.UseVisualStyleBackColor = true;
            this.btnVerFicha.Click += new System.EventHandler(this.btnVerFicha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::linQ.Properties.Resources.img1;
            this.pictureBox1.Location = new System.Drawing.Point(142, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DETALLES DEL  PRODUCTO SELECCIONADO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TextBox :";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(316, 336);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoP.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 20);
            this.textBox2.TabIndex = 12;
            // 
            // txtCategoriaP
            // 
            this.txtCategoriaP.Location = new System.Drawing.Point(480, 336);
            this.txtCategoriaP.Name = "txtCategoriaP";
            this.txtCategoriaP.Size = new System.Drawing.Size(100, 20);
            this.txtCategoriaP.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marca :";
            // 
            // txtMarcaP
            // 
            this.txtMarcaP.Location = new System.Drawing.Point(480, 310);
            this.txtMarcaP.Name = "txtMarcaP";
            this.txtMarcaP.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaP.TabIndex = 13;
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(605, 339);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(75, 23);
            this.btnAniadir.TabIndex = 17;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(442, 80);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 18;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Codigo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.txtCategoriaP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMarcaP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCodigoP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerFicha);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarP);
            this.Controls.Add(this.lstOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOriginal;
        private System.Windows.Forms.TextBox txtBuscarP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Button btnVerFicha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCategoriaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarcaP;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label4;
    }
}

