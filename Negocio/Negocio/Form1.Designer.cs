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
            btnAgregar = new Button();
            txbCodigo = new TextBox();
            txbNombre = new TextBox();
            txbPrecio = new TextBox();
            txbMarca = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 44);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 104);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 152);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 247);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 199);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 3;
            label5.Text = "Marca:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(109, 323);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(205, 101);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(253, 23);
            txbCodigo.TabIndex = 6;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(205, 149);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(253, 23);
            txbNombre.TabIndex = 7;
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(205, 244);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(253, 23);
            txbPrecio.TabIndex = 9;
            // 
            // txbMarca
            // 
            txbMarca.Location = new Point(205, 196);
            txbMarca.Name = "txbMarca";
            txbMarca.Size = new Size(253, 23);
            txbMarca.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(244, 323);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(383, 323);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
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
            Controls.Add(txbPrecio);
            Controls.Add(txbMarca);
            Controls.Add(txbNombre);
            Controls.Add(txbCodigo);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private TextBox txbCodigo;
        private TextBox txbNombre;
        private TextBox txbPrecio;
        private TextBox txbMarca;
        private Button btnEliminar;
        private Button btnModificar;
    }
}
