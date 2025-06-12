using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_2
{
    /* Colores:
     Iniciar --> Forest Green
    Detener --> Royal Blue
    Restablecer --> FireBrick
    Continuar --> Dark Orange
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)

        {
            for (int i = 0; i < 60; i++)
            {
                cbminutos.Items.Add(i);
                cbsegundos.Items.Add(i);
              
                cbminutos.SelectedItem = 0;
                cbsegundos.SelectedItem = 0;

            }



        }
        int min;
        int seg;

        private void btniniciar_Click(object sender, EventArgs e)
  
        {
            if (btniniciar.Text == "Iniciar")
            {
                min = Convert.ToInt32(cbminutos.SelectedItem);
                seg = Convert.ToInt32(cbsegundos.SelectedItem);

                lbtiempo.Text = (min < 10 ? "0" + min : min.ToString()) + ":" + (seg < 10 ? "0" + seg : seg.ToString());

                timer1.Start();
                btniniciar.Text = "Restablecer";
            }
            else
            {
                timer1.Stop();
                min = 0;
                seg = 0;
                lbtiempo.Text = "00:00";
                btniniciar.Text = "Iniciar";
                btndetener.Text = "Detener";
            }
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            if (btndetener.Text == "Detener")
            {
                timer1.Stop();
                btndetener.ForeColor = Color.DarkOrange;
                btndetener.Text = "Reanudar";

            }

            else
            {

                timer1.Start();
                btndetener.ForeColor = Color.DarkOrange;
                btndetener.Text = "Detener";

            }
        }         private void timer1_Tick_1(object sender, EventArgs e)
      
        {
            if (min == 0 && seg == 0)
            {
                timer1.Stop();
                lbtiempo.Text = "00:00";
                MessageBox.Show("Se ha acabado el tiempo.", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (seg == 0)
            {
                if (min > 0)
                {
                    min--;
                    seg = 59;
                }
            }
            else
            {
                seg--;
            }

            string minutos = min < 10 ? "0" + min.ToString() : min.ToString();
            string segundos = seg < 10 ? "0" + seg.ToString() : seg.ToString();
            lbtiempo.Text = minutos + ":" + segundos;
        
        }
    }   
 }        
