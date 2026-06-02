namespace futbol
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmbCondicion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alineación de Fútbol";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Jugador:";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(50, 120);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(50, 13);
            this.lblPosicion.TabIndex = 2;
            this.lblPosicion.Text = "Posición:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 160);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(93, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número Camiseta:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(50, 200);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(57, 13);
            this.lblCondicion.TabIndex = 4;
            this.lblCondicion.Text = "Condición:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(160, 117);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(200, 20);
            this.txtPosicion.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(160, 157);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(200, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicion.FormattingEnabled = true;
            this.cmbCondicion.Items.AddRange(new object[] {
            "Titular",
            "Suplente"});
            this.cmbCondicion.Location = new System.Drawing.Point(160, 197);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(200, 21);
            this.cmbCondicion.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(50, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(170, 250);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(290, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(410, 250);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(50, 300);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(700, 200);
            this.dgvJugadores.TabIndex = 13;
            this.dgvJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbCondicion);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Alineación de Fútbol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmbCondicion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvJugadores;
    }
}

