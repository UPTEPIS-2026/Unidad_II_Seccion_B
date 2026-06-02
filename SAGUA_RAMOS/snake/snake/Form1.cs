using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        private const int TamanoCuadro = 20;
        private const int AnchoTablero = 30;
        private const int AltoTablero = 18;
        private List<Point> serpiente;
        private Point comida;
        private Point direccion;
        private Timer temporizadorJuego;
        private Timer temporizadorTiempo;
        private Random aleatorio;
        private bool juegoTerminado;
        private bool pausado;
        private int puntaje;
        private int segundosTranscurridos;

        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }

        private void IniciarJuego()
        {
            aleatorio = new Random();
            serpiente = new List<Point>();
            serpiente.Add(new Point(5, 10));
            serpiente.Add(new Point(4, 10));
            serpiente.Add(new Point(3, 10));
            direccion = new Point(1, 0);
            puntaje = 0;
            segundosTranscurridos = 0;
            juegoTerminado = false;
            pausado = false;
            lblScore.Text = "Puntaje: 0 - Nivel: 1";
            lblTime.Text = "Tiempo: 0:00";

            GenerarComida();

            temporizadorJuego = new Timer();
            temporizadorJuego.Interval = 150;
            temporizadorJuego.Tick += TemporizadorJuego_Tick;
            temporizadorJuego.Start();

            temporizadorTiempo = new Timer();
            temporizadorTiempo.Interval = 1000;
            temporizadorTiempo.Tick += TemporizadorTiempo_Tick;
            temporizadorTiempo.Start();
        }

        private void GenerarComida()
        {
            bool posicionValida = false;
            while (!posicionValida)
            {
                comida = new Point(aleatorio.Next(0, AnchoTablero), aleatorio.Next(0, AltoTablero));
                posicionValida = !serpiente.Contains(comida);
            }
        }

        private void TemporizadorJuego_Tick(object sender, EventArgs e)
        {
            if (!juegoTerminado && !pausado)
            {
                MoverSerpiente();
                VerificarColisiones();
                pbCanvas.Invalidate();
            }
        }

        private void TemporizadorTiempo_Tick(object sender, EventArgs e)
        {
            if (!juegoTerminado && !pausado)
            {
                segundosTranscurridos++;
                int minutos = segundosTranscurridos / 60;
                int segundos = segundosTranscurridos % 60;
                lblTime.Text = string.Format("Tiempo: {0}:{1:00}", minutos, segundos);
            }
        }

        private void MoverSerpiente()
        {
            Point cabeza = serpiente[0];
            Point nuevaCabeza = new Point(cabeza.X + direccion.X, cabeza.Y + direccion.Y);
            serpiente.Insert(0, nuevaCabeza);

            if (nuevaCabeza == comida)
            {
                puntaje += 10;
                lblScore.Text = "Puntaje: " + puntaje + " - Nivel: 1";
                GenerarComida();
            }
            else
            {
                serpiente.RemoveAt(serpiente.Count - 1);
            }
        }

        private void VerificarColisiones()
        {
            Point cabeza = serpiente[0];

            if (cabeza.X < 0 || cabeza.X >= AnchoTablero || cabeza.Y < 0 || cabeza.Y >= AltoTablero)
            {
                TerminarJuego();
            }

            for (int i = 1; i < serpiente.Count; i++)
            {
                if (serpiente[i] == cabeza)
                {
                    TerminarJuego();
                }
            }
        }

        private void TerminarJuego()
        {
            juegoTerminado = true;
            temporizadorJuego.Stop();
            temporizadorTiempo.Stop();
            MessageBox.Show("¡Game Over!\nPuntaje final: " + puntaje, "Snake Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen lapizCuadricula = new Pen(Color.FromArgb(40, 40, 40));
            for (int i = 0; i <= pbCanvas.Width; i += TamanoCuadro)
                g.DrawLine(lapizCuadricula, i, 0, i, pbCanvas.Height);
            for (int i = 0; i <= pbCanvas.Height; i += TamanoCuadro)
                g.DrawLine(lapizCuadricula, 0, i, pbCanvas.Width, i);

            g.FillEllipse(Brushes.Red, comida.X * TamanoCuadro + 2, comida.Y * TamanoCuadro + 2, TamanoCuadro - 4, TamanoCuadro - 4);
            g.FillEllipse(Brushes.DarkRed, comida.X * TamanoCuadro + 4, comida.Y * TamanoCuadro + 4, TamanoCuadro - 8, TamanoCuadro - 8);
            g.FillRectangle(Brushes.Green, comida.X * TamanoCuadro + TamanoCuadro / 2 - 2, comida.Y * TamanoCuadro, 4, 6);

            for (int i = 0; i < serpiente.Count; i++)
            {
                if (i == 0)
                {
                    g.FillRectangle(Brushes.Lime, serpiente[i].X * TamanoCuadro + 1, serpiente[i].Y * TamanoCuadro + 1, TamanoCuadro - 2, TamanoCuadro - 2);
                    g.FillEllipse(Brushes.White, serpiente[i].X * TamanoCuadro + 4, serpiente[i].Y * TamanoCuadro + 4, 5, 5);
                    g.FillEllipse(Brushes.White, serpiente[i].X * TamanoCuadro + TamanoCuadro - 9, serpiente[i].Y * TamanoCuadro + 4, 5, 5);
                    g.FillEllipse(Brushes.Black, serpiente[i].X * TamanoCuadro + 5, serpiente[i].Y * TamanoCuadro + 5, 2, 2);
                    g.FillEllipse(Brushes.Black, serpiente[i].X * TamanoCuadro + TamanoCuadro - 7, serpiente[i].Y * TamanoCuadro + 5, 2, 2);
                }
                else
                {
                    g.FillRectangle(Brushes.Green, serpiente[i].X * TamanoCuadro + 1, serpiente[i].Y * TamanoCuadro + 1, TamanoCuadro - 2, TamanoCuadro - 2);
                }
            }
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            if (temporizadorJuego != null)
                temporizadorJuego.Stop();
            if (temporizadorTiempo != null)
                temporizadorTiempo.Stop();
            IniciarJuego();
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            if (pausado)
            {
                temporizadorJuego.Start();
                temporizadorTiempo.Start();
                btnPausar.Text = "PAUSAR";
                pausado = false;
            }
            else
            {
                temporizadorJuego.Stop();
                temporizadorTiempo.Stop();
                btnPausar.Text = "CONTINUAR";
                pausado = true;
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!juegoTerminado && !pausado)
            {
                if (keyData == Keys.Up && direccion.Y != 1)
                    direccion = new Point(0, -1);
                else if (keyData == Keys.Down && direccion.Y != -1)
                    direccion = new Point(0, 1);
                else if (keyData == Keys.Left && direccion.X != 1)
                    direccion = new Point(-1, 0);
                else if (keyData == Keys.Right && direccion.X != -1)
                    direccion = new Point(1, 0);
                else if (keyData == Keys.Space)
                    BtnPausar_Click(this, EventArgs.Empty);
            }
            else if (keyData == Keys.Enter)
                BtnReiniciar_Click(this, EventArgs.Empty);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
