using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear();

            if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFin.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El valor de inicio debe ser menor o igual al valor de fin.");
                    return;
                }

                for (int i = inicio; i <= fin; i++)
                {
                    if (EsPrimo(i))
                        listBoxPrimos.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos.");
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}