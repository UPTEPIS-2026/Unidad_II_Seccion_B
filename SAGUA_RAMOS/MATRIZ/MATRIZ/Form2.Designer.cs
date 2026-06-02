namespace Figuras
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelVolumen = new System.Windows.Forms.Label();
            this.labelAreaPerimetro = new System.Windows.Forms.Label();
            this.btnEsfera = new System.Windows.Forms.Button();
            this.btnCubo = new System.Windows.Forms.Button();
            this.btnCilindro = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.txtMedida1 = new System.Windows.Forms.TextBox();
            this.txtMedida2 = new System.Windows.Forms.TextBox();
            this.lblMedida1 = new System.Windows.Forms.Label();
            this.lblMedida2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(280, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(221, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "¿Que deseas Calcular?";
            // 
            // labelVolumen
            // 
            this.labelVolumen.AutoSize = true;
            this.labelVolumen.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumen.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelVolumen.Location = new System.Drawing.Point(30, 70);
            this.labelVolumen.Name = "labelVolumen";
            this.labelVolumen.Size = new System.Drawing.Size(98, 23);
            this.labelVolumen.TabIndex = 1;
            this.labelVolumen.Text = "VOLUMEN";
            // 
            // labelAreaPerimetro
            // 
            this.labelAreaPerimetro.AutoSize = true;
            this.labelAreaPerimetro.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaPerimetro.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelAreaPerimetro.Location = new System.Drawing.Point(30, 250);
            this.labelAreaPerimetro.Name = "labelAreaPerimetro";
            this.labelAreaPerimetro.Size = new System.Drawing.Size(183, 23);
            this.labelAreaPerimetro.TabIndex = 2;
            this.labelAreaPerimetro.Text = "AREA Y PERIMETRO";
            // 
            // btnEsfera
            // 
            this.btnEsfera.BackColor = System.Drawing.Color.Yellow;
            this.btnEsfera.Location = new System.Drawing.Point(40, 180);
            this.btnEsfera.Name = "btnEsfera";
            this.btnEsfera.Size = new System.Drawing.Size(75, 23);
            this.btnEsfera.TabIndex = 3;
            this.btnEsfera.Text = "Esfera";
            this.btnEsfera.UseVisualStyleBackColor = false;
            this.btnEsfera.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnCubo
            // 
            this.btnCubo.BackColor = System.Drawing.Color.Yellow;
            this.btnCubo.Location = new System.Drawing.Point(180, 180);
            this.btnCubo.Name = "btnCubo";
            this.btnCubo.Size = new System.Drawing.Size(75, 23);
            this.btnCubo.TabIndex = 4;
            this.btnCubo.Text = "Cubo";
            this.btnCubo.UseVisualStyleBackColor = false;
            this.btnCubo.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnCilindro
            // 
            this.btnCilindro.BackColor = System.Drawing.Color.Yellow;
            this.btnCilindro.Location = new System.Drawing.Point(320, 180);
            this.btnCilindro.Name = "btnCilindro";
            this.btnCilindro.Size = new System.Drawing.Size(75, 23);
            this.btnCilindro.TabIndex = 5;
            this.btnCilindro.Text = "Cilindro";
            this.btnCilindro.UseVisualStyleBackColor = false;
            this.btnCilindro.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(40, 380);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(75, 23);
            this.btnCuadrado.TabIndex = 6;
            this.btnCuadrado.Text = "Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(180, 380);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRectangulo.TabIndex = 7;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(320, 380);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnTriangulo.TabIndex = 8;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(460, 380);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 9;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // txtMedida1
            // 
            this.txtMedida1.Location = new System.Drawing.Point(620, 100);
            this.txtMedida1.Name = "txtMedida1";
            this.txtMedida1.Size = new System.Drawing.Size(100, 20);
            this.txtMedida1.TabIndex = 10;
            this.txtMedida1.Visible = false;
            this.txtMedida1.TextChanged += new System.EventHandler(this.txtMedida_TextChanged);
            // 
            // txtMedida2
            // 
            this.txtMedida2.Location = new System.Drawing.Point(620, 150);
            this.txtMedida2.Name = "txtMedida2";
            this.txtMedida2.Size = new System.Drawing.Size(100, 20);
            this.txtMedida2.TabIndex = 11;
            this.txtMedida2.Visible = false;
            this.txtMedida2.TextChanged += new System.EventHandler(this.txtMedida_TextChanged);
            // 
            // lblMedida1
            // 
            this.lblMedida1.AutoSize = true;
            this.lblMedida1.Location = new System.Drawing.Point(620, 80);
            this.lblMedida1.Name = "lblMedida1";
            this.lblMedida1.Size = new System.Drawing.Size(54, 13);
            this.lblMedida1.TabIndex = 12;
            this.lblMedida1.Text = "Medida 1:";
            this.lblMedida1.Visible = false;
            // 
            // lblMedida2
            // 
            this.lblMedida2.AutoSize = true;
            this.lblMedida2.Location = new System.Drawing.Point(620, 130);
            this.lblMedida2.Name = "lblMedida2";
            this.lblMedida2.Size = new System.Drawing.Size(54, 13);
            this.lblMedida2.TabIndex = 13;
            this.lblMedida2.Text = "Medida 2:";
            this.lblMedida2.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(580, 220);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 16);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(620, 300);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMedida2);
            this.Controls.Add(this.lblMedida1);
            this.Controls.Add(this.txtMedida2);
            this.Controls.Add(this.txtMedida1);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnCilindro);
            this.Controls.Add(this.btnCubo);
            this.Controls.Add(this.btnEsfera);
            this.Controls.Add(this.labelAreaPerimetro);
            this.Controls.Add(this.labelVolumen);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form2";
            this.Text = "Calculadora de Figuras Geometricas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelVolumen;
        private System.Windows.Forms.Label labelAreaPerimetro;
        private System.Windows.Forms.Button btnEsfera;
        private System.Windows.Forms.Button btnCubo;
        private System.Windows.Forms.Button btnCilindro;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.TextBox txtMedida1;
        private System.Windows.Forms.TextBox txtMedida2;
        private System.Windows.Forms.Label lblMedida1;
        private System.Windows.Forms.Label lblMedida2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;

        #endregion
    }
}