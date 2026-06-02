namespace tarea
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNC = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.Location = new System.Drawing.Point(30, 30);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(30, 15);
            this.lblNC.TabIndex = 0;
            this.lblNC.Text = "NC:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(30, 90);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(72, 15);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 120);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(99, 15);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(30, 150);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(78, 15);
            this.lblFechaIngreso.TabIndex = 4;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.Location = new System.Drawing.Point(200, 250);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(80, 17);
            this.lblPosicion.TabIndex = 5;
            this.lblPosicion.Text = "No registros";
            // 
            // txtNC
            // 
            this.txtNC.Location = new System.Drawing.Point(150, 27);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(200, 23);
            this.txtNC.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(150, 87);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(200, 23);
            this.txtEspecialidad.TabIndex = 8;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(150, 117);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.txtFechaNacimiento.TabIndex = 9;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(150, 147);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.txtFechaIngreso.TabIndex = 10;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 180);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 23);
            this.txtBuscar.TabIndex = 11;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(30, 240);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 30);
            this.btnPrimero.TabIndex = 12;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(111, 240);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 30);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(290, 240);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 30);
            this.btnSiguiente.TabIndex = 14;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(371, 240);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 30);
            this.btnUltimo.TabIndex = 15;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(380, 25);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(75, 30);
            this.btnAniadir.TabIndex = 16;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(380, 55);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 30);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(380, 178);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNC);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
