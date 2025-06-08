using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_3.Actividad_Práctica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbtabla.Items.Clear();

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            lbtabla.Items.Clear();

            if (int.TryParse(tbnumeros.Text, out int numero))
            {
                for (int i = 1; i <= 12; i++)
                {
                    int producto = numero * i;
                    lbtabla.Items.Add($"{numero} x {i} = {producto}");

                }


            }

        }
    }
}
