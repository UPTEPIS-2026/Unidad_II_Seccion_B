namespace Registro_de_Contactos
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
            this.lblIdContacto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNumContacto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNumContacto = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvListaContactos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdContacto
            // 
            this.lblIdContacto.AutoSize = true;
            this.lblIdContacto.Location = new System.Drawing.Point(29, 61);
            this.lblIdContacto.Name = "lblIdContacto";
            this.lblIdContacto.Size = new System.Drawing.Size(79, 13);
            this.lblIdContacto.TabIndex = 0;
            this.lblIdContacto.Text = "ID de Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 115);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNumContacto
            // 
            this.lblNumContacto.AutoSize = true;
            this.lblNumContacto.Location = new System.Drawing.Point(31, 143);
            this.lblNumContacto.Name = "lblNumContacto";
            this.lblNumContacto.Size = new System.Drawing.Size(93, 13);
            this.lblNumContacto.TabIndex = 3;
            this.lblNumContacto.Text = "Núm. de Contacto";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(33, 169);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(33, 260);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Género";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(289, 65);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(113, 58);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.ReadOnly = true;
            this.txtIdContacto.Size = new System.Drawing.Size(124, 20);
            this.txtIdContacto.TabIndex = 7;
            this.txtIdContacto.TextChanged += new System.EventHandler(this.txtIdContacto_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(113, 110);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(124, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNumContacto
            // 
            this.txtNumContacto.Location = new System.Drawing.Point(113, 136);
            this.txtNumContacto.Name = "txtNumContacto";
            this.txtNumContacto.Size = new System.Drawing.Size(124, 20);
            this.txtNumContacto.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(113, 166);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(124, 73);
            this.txtDireccion.TabIndex = 11;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(113, 260);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 12;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(353, 62);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(124, 20);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // dgvListaContactos
            // 
            this.dgvListaContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaContactos.Location = new System.Drawing.Point(292, 110);
            this.dgvListaContactos.Name = "dgvListaContactos";
            this.dgvListaContactos.ReadOnly = true;
            this.dgvListaContactos.Size = new System.Drawing.Size(460, 180);
            this.dgvListaContactos.TabIndex = 14;
            this.dgvListaContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaContactos_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(45, 319);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 54);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(193, 319);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(113, 54);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(344, 319);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 54);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(488, 319);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 54);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(225, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 31);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "E CONTACT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvListaContactos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNumContacto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNumContacto);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdContacto);
            this.Name = "Form1";
            this.Text = "E Contact";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdContacto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNumContacto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNumContacto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvListaContactos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTitulo;
    }
}

