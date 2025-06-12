using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura el MaskedTextBox para aceptar solo números de hasta 5 dígitos
            maskedTextBox1.Mask = "00000"; // Cambia la cantidad de ceros si deseas más dígitos
            maskedTextBox1.ValidatingType = typeof(int);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(maskedTextBox1.Text, out numero))
            {
                if (EsPrimo(numero))
                {
                    MessageBox.Show("El número " + numero + " es primo.", "Resultado");
                }
                else
                {
                    MessageBox.Show("El número " + numero + " no es primo.", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error");
            }
        }

        private bool EsPrimo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
        
    

