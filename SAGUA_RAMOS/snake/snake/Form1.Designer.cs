namespace snake
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.btnReiniciar);
            this.topPanel.Controls.Add(this.btnPausar);
            this.topPanel.Controls.Add(this.btnFinalizar);
            this.topPanel.Controls.Add(this.lblScore);
            this.topPanel.Controls.Add(this.lblTime);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 60);
            this.topPanel.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.LightGray;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.Location = new System.Drawing.Point(480, 15);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(80, 30);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.LightGray;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnPausar.Location = new System.Drawing.Point(565, 15);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(70, 30);
            this.btnPausar.TabIndex = 2;
            this.btnPausar.Text = "PAUSAR";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LightGray;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.Location = new System.Drawing.Point(640, 15);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(70, 30);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(15, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(220, 22);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Puntaje: 0 - Nivel: 1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(320, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 22);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Tiempo: 0:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Black;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCanvas.Location = new System.Drawing.Point(100, 70);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(600, 360);
            this.pbCanvas.TabIndex = 1;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCanvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pbCanvas;
    }
}
