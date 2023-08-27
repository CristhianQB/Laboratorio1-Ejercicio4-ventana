using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1_Ejercicio4_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salona = int.Parse(txtb1.Text);
            int salonb = int.Parse(txtb2.Text);
            int salonc = int.Parse(txtb3.Text);

            int tsalona = salona * 5;
            int tsalonb = salonb * 8;
            int tsalonc = salonc * 6;
            int total1 = tsalona + tsalonb + tsalonc;

            if (total1 % 60 == 0)
            {
                int total2 = total1 / 60;
                lbl.Text = total2 + " horas()";
            }
            else
            {
                int minutos = total1 % 60;
                int total2 = total1 / 60;
                lbl.Text = total2 + " hora(s) y " + minutos + " minuto(s)" ;
            }
        }
    }
}
