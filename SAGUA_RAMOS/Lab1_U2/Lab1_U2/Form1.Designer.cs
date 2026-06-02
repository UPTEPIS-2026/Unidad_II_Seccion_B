namespace Lab1_U2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMayores = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCabeza = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabeza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE PERSONAS CON LINQ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "EDAD:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(131, 141);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 197);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMayores
            // 
            this.btnMayores.Location = new System.Drawing.Point(156, 197);
            this.btnMayores.Name = "btnMayores";
            this.btnMayores.Size = new System.Drawing.Size(75, 23);
            this.btnMayores.TabIndex = 6;
            this.btnMayores.Text = "MAYORES";
            this.btnMayores.UseVisualStyleBackColor = true;
            this.btnMayores.Click += new System.EventHandler(this.btnMayores_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(256, 197);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 7;
            this.btnPromedio.Text = "PROMEDIO";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(148, 253);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "BUSCAR:";
            // 
            // dgvCabeza
            // 
            this.dgvCabeza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabeza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombre,
            this.dgvEdad});
            this.dgvCabeza.Location = new System.Drawing.Point(55, 288);
            this.dgvCabeza.Name = "dgvCabeza";
            this.dgvCabeza.Size = new System.Drawing.Size(423, 150);
            this.dgvCabeza.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(514, 425);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 11;
            // 
            // dgvNombre
            // 
            this.dgvNombre.DataPropertyName = "Nombre";
            this.dgvNombre.HeaderText = "NOMBRE";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvEdad
            // 
            this.dgvEdad.DataPropertyName = "Edad";
            this.dgvEdad.HeaderText = "EDAD";
            this.dgvEdad.Name = "dgvEdad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(270, 253);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvCabeza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnMayores);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabeza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMayores;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCabeza;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEdad;
        private System.Windows.Forms.Button btnBuscar;
    }
}

