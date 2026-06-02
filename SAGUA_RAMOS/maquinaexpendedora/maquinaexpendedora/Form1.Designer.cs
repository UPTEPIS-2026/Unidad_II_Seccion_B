namespace maquinaexpendedora
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
            this.gpbReporteVentas = new System.Windows.Forms.GroupBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rbtnAno = new System.Windows.Forms.RadioButton();
            this.rbtnMes = new System.Windows.Forms.RadioButton();
            this.rbtnDia = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbCredito = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.gpbMonedas = new System.Windows.Forms.GroupBox();
            this.gpbMensaje = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gpbCodProducto = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.lblCredito = new System.Windows.Forms.Label();
            this.gpbVuelto = new System.Windows.Forms.GroupBox();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.gpbReporteVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbCredito.SuspendLayout();
            this.gpbMonedas.SuspendLayout();
            this.gpbMensaje.SuspendLayout();
            this.gpbCodProducto.SuspendLayout();
            this.gpbVuelto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbReporteVentas
            // 
            this.gpbReporteVentas.Controls.Add(this.dgvReporte);
            this.gpbReporteVentas.Controls.Add(this.btnMostrar);
            this.gpbReporteVentas.Controls.Add(this.rbtnAno);
            this.gpbReporteVentas.Controls.Add(this.rbtnMes);
            this.gpbReporteVentas.Controls.Add(this.rbtnDia);
            this.gpbReporteVentas.Location = new System.Drawing.Point(12, 298);
            this.gpbReporteVentas.Name = "gpbReporteVentas";
            this.gpbReporteVentas.Size = new System.Drawing.Size(588, 235);
            this.gpbReporteVentas.TabIndex = 0;
            this.gpbReporteVentas.TabStop = false;
            this.gpbReporteVentas.Text = "REPORTE DE VENTAS";
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(6, 52);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(576, 177);
            this.dgvReporte.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(348, 13);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rbtnAno
            // 
            this.rbtnAno.AutoSize = true;
            this.rbtnAno.Location = new System.Drawing.Point(231, 19);
            this.rbtnAno.Name = "rbtnAno";
            this.rbtnAno.Size = new System.Drawing.Size(74, 17);
            this.rbtnAno.TabIndex = 3;
            this.rbtnAno.TabStop = true;
            this.rbtnAno.Text = "POR AÑO";
            this.rbtnAno.UseVisualStyleBackColor = true;
            // 
            // rbtnMes
            // 
            this.rbtnMes.AutoSize = true;
            this.rbtnMes.Location = new System.Drawing.Point(112, 19);
            this.rbtnMes.Name = "rbtnMes";
            this.rbtnMes.Size = new System.Drawing.Size(74, 17);
            this.rbtnMes.TabIndex = 1;
            this.rbtnMes.TabStop = true;
            this.rbtnMes.Text = "POR MES";
            this.rbtnMes.UseVisualStyleBackColor = true;
            // 
            // rbtnDia
            // 
            this.rbtnDia.AutoSize = true;
            this.rbtnDia.Location = new System.Drawing.Point(6, 19);
            this.rbtnDia.Name = "rbtnDia";
            this.rbtnDia.Size = new System.Drawing.Size(69, 17);
            this.rbtnDia.TabIndex = 0;
            this.rbtnDia.TabStop = true;
            this.rbtnDia.Text = "POR DIA";
            this.rbtnDia.UseVisualStyleBackColor = true;
            this.rbtnDia.CheckedChanged += new System.EventHandler(this.rbtnDia_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::maquinaexpendedora.Properties.Resources.img1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTOS";
            // 
            // gpbCredito
            // 
            this.gpbCredito.Controls.Add(this.btnComprar);
            this.gpbCredito.Controls.Add(this.gpbMonedas);
            this.gpbCredito.Controls.Add(this.lblCredito);
            this.gpbCredito.Location = new System.Drawing.Point(638, 53);
            this.gpbCredito.Name = "gpbCredito";
            this.gpbCredito.Size = new System.Drawing.Size(245, 501);
            this.gpbCredito.TabIndex = 3;
            this.gpbCredito.TabStop = false;
            this.gpbCredito.Text = "CRÉDITO INGRESADO";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(21, 264);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(200, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // gpbMonedas
            // 
            this.gpbMonedas.Controls.Add(this.gpbMensaje);
            this.gpbMonedas.Controls.Add(this.gpbCodProducto);
            this.gpbMonedas.Controls.Add(this.btn10);
            this.gpbMonedas.Controls.Add(this.btn20);
            this.gpbMonedas.Controls.Add(this.btn50);
            this.gpbMonedas.Controls.Add(this.btn1);
            this.gpbMonedas.Controls.Add(this.btn2);
            this.gpbMonedas.Controls.Add(this.btn5);
            this.gpbMonedas.Location = new System.Drawing.Point(0, 79);
            this.gpbMonedas.Name = "gpbMonedas";
            this.gpbMonedas.Size = new System.Drawing.Size(245, 286);
            this.gpbMonedas.TabIndex = 1;
            this.gpbMonedas.TabStop = false;
            this.gpbMonedas.Text = "INGRESAR MONEDAS";
            this.gpbMonedas.UseCompatibleTextRendering = true;
            this.gpbMonedas.Enter += new System.EventHandler(this.gpbMonedas_Enter);
            // 
            // gpbMensaje
            // 
            this.gpbMensaje.Controls.Add(this.lblMensaje);
            this.gpbMensaje.Location = new System.Drawing.Point(0, 218);
            this.gpbMensaje.Name = "gpbMensaje";
            this.gpbMensaje.Size = new System.Drawing.Size(245, 100);
            this.gpbMensaje.TabIndex = 7;
            this.gpbMensaje.TabStop = false;
            this.gpbMensaje.Text = "MENSAJE";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(55, 16);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(100, 23);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Bienvenido";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbCodProducto
            // 
            this.gpbCodProducto.Controls.Add(this.label2);
            this.gpbCodProducto.Controls.Add(this.txtCodigo);
            this.gpbCodProducto.Location = new System.Drawing.Point(0, 119);
            this.gpbCodProducto.Name = "gpbCodProducto";
            this.gpbCodProducto.Size = new System.Drawing.Size(245, 100);
            this.gpbCodProducto.TabIndex = 6;
            this.gpbCodProducto.TabStop = false;
            this.gpbCodProducto.Text = "CÓDIGO DEL PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(91, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Gold;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn10.Location = new System.Drawing.Point(113, 63);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(42, 38);
            this.btn10.TabIndex = 5;
            this.btn10.Text = "S/ 0.10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.Gold;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn20.Location = new System.Drawing.Point(67, 63);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(42, 38);
            this.btn20.TabIndex = 4;
            this.btn20.Text = "S/ 0.20";
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.Gold;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn50.Location = new System.Drawing.Point(21, 63);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(42, 38);
            this.btn50.TabIndex = 3;
            this.btn50.Text = "S/ 0.50";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gold;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(113, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 38);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "S/1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gold;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(67, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "S/2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gold;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(21, 19);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 38);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "S/ 5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // lblCredito
            // 
            this.lblCredito.BackColor = System.Drawing.Color.White;
            this.lblCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCredito.ForeColor = System.Drawing.Color.Green;
            this.lblCredito.Location = new System.Drawing.Point(21, 27);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(200, 31);
            this.lblCredito.TabIndex = 0;
            this.lblCredito.Text = "S/ 0.00";
            this.lblCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbVuelto
            // 
            this.gpbVuelto.Controls.Add(this.lblVuelto);
            this.gpbVuelto.Location = new System.Drawing.Point(638, 415);
            this.gpbVuelto.Name = "gpbVuelto";
            this.gpbVuelto.Size = new System.Drawing.Size(245, 100);
            this.gpbVuelto.TabIndex = 1;
            this.gpbVuelto.TabStop = false;
            this.gpbVuelto.Text = "VUELTO";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Location = new System.Drawing.Point(50, 20);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(22, 13);
            this.lblVuelto.TabIndex = 0;
            this.lblVuelto.Text = ":::::";
            this.lblVuelto.Click += new System.EventHandler(this.lblVuelto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 645);
            this.Controls.Add(this.gpbVuelto);
            this.Controls.Add(this.gpbCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbReporteVentas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbReporteVentas.ResumeLayout(false);
            this.gpbReporteVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbCredito.ResumeLayout(false);
            this.gpbMonedas.ResumeLayout(false);
            this.gpbMensaje.ResumeLayout(false);
            this.gpbCodProducto.ResumeLayout(false);
            this.gpbCodProducto.PerformLayout();
            this.gpbVuelto.ResumeLayout(false);
            this.gpbVuelto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReporteVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RadioButton rbtnAno;
        private System.Windows.Forms.RadioButton rbtnMes;
        private System.Windows.Forms.RadioButton rbtnDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbCredito;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.GroupBox gpbMonedas;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox gpbCodProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gpbMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.GroupBox gpbVuelto;
        private System.Windows.Forms.Label lblVuelto;
    }
}

