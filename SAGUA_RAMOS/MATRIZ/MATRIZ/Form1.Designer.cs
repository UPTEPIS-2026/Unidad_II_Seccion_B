namespace MATRIZ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.btnCrearMatriz = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvMatrizA = new System.Windows.Forms.DataGridView();
            this.dgvMatrizB = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lblMatrizA = new System.Windows.Forms.Label();
            this.lblMatrizB = new System.Windows.Forms.Label();
            this.lblMatrizResultado = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngresaDatosA = new System.Windows.Forms.TextBox();
            this.txtIngresaDatosB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(265, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplicación de Matrices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Filas";
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(130, 72);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(80, 20);
            this.txtFilas.TabIndex = 2;
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(130, 102);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(80, 20);
            this.txtColumnas.TabIndex = 3;
            // 
            // btnCrearMatriz
            // 
            this.btnCrearMatriz.Location = new System.Drawing.Point(250, 85);
            this.btnCrearMatriz.Name = "btnCrearMatriz";
            this.btnCrearMatriz.Size = new System.Drawing.Size(100, 30);
            this.btnCrearMatriz.TabIndex = 4;
            this.btnCrearMatriz.Text = "Crear Matriz";
            this.btnCrearMatriz.UseVisualStyleBackColor = true;
            this.btnCrearMatriz.Click += new System.EventHandler(this.btnCrearMatriz_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(150, 400);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(100, 40);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(330, 400);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 40);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(510, 400);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 40);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar al MENÚ";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvMatrizA
            // 
            this.dgvMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizA.Location = new System.Drawing.Point(50, 200);
            this.dgvMatrizA.Name = "dgvMatrizA";
            this.dgvMatrizA.Size = new System.Drawing.Size(180, 160);
            this.dgvMatrizA.TabIndex = 8;
            this.dgvMatrizA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrizA_CellContentClick);
            // 
            // dgvMatrizB
            // 
            this.dgvMatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizB.Location = new System.Drawing.Point(300, 200);
            this.dgvMatrizB.Name = "dgvMatrizB";
            this.dgvMatrizB.Size = new System.Drawing.Size(180, 160);
            this.dgvMatrizB.TabIndex = 9;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(550, 200);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(180, 160);
            this.dgvResultado.TabIndex = 10;
            this.dgvResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellContentClick);
            // 
            // lblMatrizA
            // 
            this.lblMatrizA.AutoSize = true;
            this.lblMatrizA.Location = new System.Drawing.Point(115, 175);
            this.lblMatrizA.Name = "lblMatrizA";
            this.lblMatrizA.Size = new System.Drawing.Size(45, 13);
            this.lblMatrizA.TabIndex = 11;
            this.lblMatrizA.Text = "Matriz A";
            // 
            // lblMatrizB
            // 
            this.lblMatrizB.AutoSize = true;
            this.lblMatrizB.Location = new System.Drawing.Point(365, 175);
            this.lblMatrizB.Name = "lblMatrizB";
            this.lblMatrizB.Size = new System.Drawing.Size(45, 13);
            this.lblMatrizB.TabIndex = 12;
            this.lblMatrizB.Text = "Matriz B";
            // 
            // lblMatrizResultado
            // 
            this.lblMatrizResultado.AutoSize = true;
            this.lblMatrizResultado.Location = new System.Drawing.Point(595, 175);
            this.lblMatrizResultado.Name = "lblMatrizResultado";
            this.lblMatrizResultado.Size = new System.Drawing.Size(86, 13);
            this.lblMatrizResultado.TabIndex = 13;
            this.lblMatrizResultado.Text = "Matriz Resultado";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(250, 260);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(26, 31);
            this.lblOperador.TabIndex = 14;
            this.lblOperador.Text = "*";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(500, 260);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(31, 31);
            this.lblIgual.TabIndex = 15;
            this.lblIgual.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ingresar datos A:";
            // 
            // txtIngresaDatosA
            // 
            this.txtIngresaDatosA.Location = new System.Drawing.Point(139, 136);
            this.txtIngresaDatosA.Name = "txtIngresaDatosA";
            this.txtIngresaDatosA.Size = new System.Drawing.Size(100, 20);
            this.txtIngresaDatosA.TabIndex = 17;
            this.txtIngresaDatosA.TextChanged += new System.EventHandler(this.txtIngresaDatosA_TextChanged);
            // 
            // txtIngresaDatosB
            // 
            this.txtIngresaDatosB.Location = new System.Drawing.Point(389, 139);
            this.txtIngresaDatosB.Name = "txtIngresaDatosB";
            this.txtIngresaDatosB.Size = new System.Drawing.Size(100, 20);
            this.txtIngresaDatosB.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ingresar datos B:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtIngresaDatosB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIngresaDatosA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblMatrizResultado);
            this.Controls.Add(this.lblMatrizB);
            this.Controls.Add(this.lblMatrizA);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.dgvMatrizB);
            this.Controls.Add(this.dgvMatrizA);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnCrearMatriz);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Button btnCrearMatriz;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvMatrizA;
        private System.Windows.Forms.DataGridView dgvMatrizB;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label lblMatrizA;
        private System.Windows.Forms.Label lblMatrizB;
        private System.Windows.Forms.Label lblMatrizResultado;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngresaDatosA;
        private System.Windows.Forms.TextBox txtIngresaDatosB;
        private System.Windows.Forms.Label label5;
    }
}

