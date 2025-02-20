using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace CronometroTaller1
{
    public partial class Cronometro: Form
    {
        private int segundos = 0;
        private int minutos = 0;
        private int horas = 0;
        private bool corriendo = false;
        private bool pausado = false;
        private System.Timers.Timer timer;
        public Cronometro()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }
            if (minutos == 60)
            {
                horas++;
                minutos = 0;
            }

            Invoke((MethodInvoker)(() =>
            {
                txtPantalla.Text = horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00");

            }));
        }

        private void btnDarkWhiteMode_Click(object sender, EventArgs e)
        {
            if ( Cronometro.ActiveForm.BackColor == Color.Black )
            {
                ActivarModoClaro();

            } else if (Cronometro.ActiveForm.BackColor == Color.White)
            {
                ActivarModoOscuro();
            }
            

        }

        private void ActivarModoClaro()
        {
            btnDarkWhiteMode.Text = "Dark Mode";
            btnDarkWhiteMode.ForeColor = Color.Black;
            Cronometro.ActiveForm.BackColor = Color.White;
            txtPantalla.ForeColor = Color.Black;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.White;
            btnPausar.FlatAppearance.MouseOverBackColor = Color.White;
            btnReiniciar.FlatAppearance.MouseOverBackColor = Color.White;
        }

        private void ActivarModoOscuro()
        {
            btnDarkWhiteMode.Text = "Light Mode";
            btnDarkWhiteMode.ForeColor = Color.White;
            Cronometro.ActiveForm.BackColor = Color.Black;
            txtPantalla.ForeColor = Color.White;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnPausar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnReiniciar.FlatAppearance.MouseOverBackColor = Color.Black;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!corriendo)
            {
                timer.Start();
                corriendo = true;
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (corriendo)
            {
                timer.Stop();
                corriendo = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            corriendo = false;
            timer.Stop();
            horas = 0;
            minutos = 0;
            segundos = 0;
            txtPantalla.Text = "00:00:00";
        }
    }

}
