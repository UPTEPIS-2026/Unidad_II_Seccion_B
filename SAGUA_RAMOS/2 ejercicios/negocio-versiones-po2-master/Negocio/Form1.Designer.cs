namespace Negocio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 38);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 97);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 137);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 177);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 217);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(271, 94);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(250, 23);
            txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(271, 134);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(271, 174);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(250, 23);
            txtMarca.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(271, 214);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(250, 23);
            txtPrecio.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(174, 280);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(310, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(446, 280);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 30);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}
