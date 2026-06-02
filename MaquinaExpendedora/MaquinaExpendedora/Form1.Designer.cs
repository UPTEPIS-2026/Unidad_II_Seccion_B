namespace MaquinaExpendedora
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            buttonPunto = new Button();
            buttonDel = new Button();
            button0 = new Button();
            buttonChange = new Button();
            buttonEnter = new Button();
            buttonExit = new Button();
            panelProductos = new Panel();
            textBoxSeleccion = new TextBox();
            textBoxDinero = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(566, 172);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "HACER SELECCIÓN";
            // 
            // button1
            // 
            button1.Location = new Point(553, 289);
            button1.Name = "button1";
            button1.Size = new Size(51, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(624, 289);
            button2.Name = "button2";
            button2.Size = new Size(51, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(695, 289);
            button3.Name = "button3";
            button3.Size = new Size(51, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(624, 325);
            button5.Name = "button5";
            button5.Size = new Size(51, 23);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(695, 325);
            button6.Name = "button6";
            button6.Size = new Size(51, 23);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(553, 325);
            button4.Name = "button4";
            button4.Size = new Size(51, 23);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(553, 360);
            button7.Name = "button7";
            button7.Size = new Size(51, 23);
            button7.TabIndex = 10;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(695, 360);
            button9.Name = "button9";
            button9.Size = new Size(51, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(624, 360);
            button8.Name = "button8";
            button8.Size = new Size(51, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // buttonPunto
            // 
            buttonPunto.Location = new Point(553, 396);
            buttonPunto.Name = "buttonPunto";
            buttonPunto.Size = new Size(51, 23);
            buttonPunto.TabIndex = 13;
            buttonPunto.Text = ".";
            buttonPunto.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(695, 396);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(51, 23);
            buttonDel.TabIndex = 12;
            buttonDel.Text = "DEL";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // button0
            // 
            button0.Location = new Point(624, 396);
            button0.Name = "button0";
            button0.Size = new Size(51, 23);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(752, 325);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(78, 23);
            buttonChange.TabIndex = 14;
            buttonChange.Text = "CHANGE";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(752, 396);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(78, 23);
            buttonEnter.TabIndex = 16;
            buttonEnter.Text = "ENTER";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(752, 360);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(78, 23);
            buttonExit.TabIndex = 15;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelProductos
            // 
            panelProductos.Location = new Point(63, 66);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(439, 392);
            panelProductos.TabIndex = 17;
            panelProductos.Paint += panelProductos_Paint;
            // 
            // textBoxSeleccion
            // 
            textBoxSeleccion.Location = new Point(566, 190);
            textBoxSeleccion.Name = "textBoxSeleccion";
            textBoxSeleccion.Size = new Size(180, 23);
            textBoxSeleccion.TabIndex = 18;
            // 
            // textBoxDinero
            // 
            textBoxDinero.Location = new Point(566, 111);
            textBoxDinero.Name = "textBoxDinero";
            textBoxDinero.Size = new Size(180, 23);
            textBoxDinero.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 697);
            Controls.Add(textBoxDinero);
            Controls.Add(textBoxSeleccion);
            Controls.Add(label1);
            Controls.Add(panelProductos);
            Controls.Add(buttonEnter);
            Controls.Add(buttonExit);
            Controls.Add(buttonChange);
            Controls.Add(buttonPunto);
            Controls.Add(buttonDel);
            Controls.Add(button0);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button button7;
        private Button button9;
        private Button button8;
        private Button buttonPunto;
        private Button buttonDel;
        private Button button0;
        private Button buttonChange;
        private Button buttonEnter;
        private Button buttonExit;
        private Panel panelProductos;
        private TextBox textBoxSeleccion;
        private TextBox textBoxDinero;
    }
}
