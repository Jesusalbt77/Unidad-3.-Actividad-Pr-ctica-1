using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Configurar el MaskedTextBox para aceptar solo números
            maskedTextBox1.Mask = "0000000000"; // hasta 10 dígitos
            maskedTextBox1.ValidatingType = typeof(int);
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text, out int numero))
            {
                if (EsNumeroPerfecto(numero))
                {
                    MessageBox.Show($"{numero} es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para verificar si un número es perfecto
        private bool EsNumeroPerfecto(int n)
        {
            if (n <= 0) return false;
            int suma = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    suma += i;
                }
            }
            return suma == n;
        }
    }

}

