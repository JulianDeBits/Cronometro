using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronometroTaller1
{
    public partial class Cronometro: Form
    {
        private int segundos = 0;
        private int minutos = 0;
        private int horas = 0;
        private bool corriendo = false;
        private bool pausado = false;
        public Cronometro()
        {
            InitializeComponent();
        }

        private void btnDarkWhiteMode_Click(object sender, EventArgs e)
        {
            if ( Cronometro.ActiveForm.BackColor == Color.Black )
            {
                btnDarkWhiteMode.Text = "Dark Mode";
                btnDarkWhiteMode.ForeColor = Color.Black;
                Cronometro.ActiveForm.BackColor = Color.White;
                txtPantalla.ForeColor = Color.Black;
                btnIniciar.FlatAppearance.MouseOverBackColor = Color.White;
                btnPausar.FlatAppearance.MouseOverBackColor = Color.White;
                btnReiniciar.FlatAppearance.MouseOverBackColor = Color.White;

            } else if (Cronometro.ActiveForm.BackColor == Color.White)
            {
                btnDarkWhiteMode.Text = "Light Mode";
                btnDarkWhiteMode.ForeColor = Color.White;
                Cronometro.ActiveForm.BackColor = Color.Black;
                txtPantalla.ForeColor = Color.White;
                btnIniciar.FlatAppearance.MouseOverBackColor = Color.Black;
                btnPausar.FlatAppearance.MouseOverBackColor = Color.Black;
                btnReiniciar.FlatAppearance.MouseOverBackColor = Color.Black;
            }
            

        }
    }

}
