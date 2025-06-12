using System;
using System.Windows.Forms;

namespace Formulario_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);

            string palabra = textBox1.Text.ToLower().Replace("[^a-z0-91]", ""); // Convertir a minuscula y quitar espacios

            // Invertir la palabra 
            char[] arr = palabra.ToCharArray();
            Array.Reverse(arr);
            string palabraInvertida = new string (arr);

            // Comparar
            if (palabra == palabraInvertida)
            {
                MessageBox.Show(" Es una palabra políndroma.", "Resultado");
                    
                }
            else 

                {
                MessageBox.Show(" No es una palabra políndroma. ", "Resultado");
            }
        }
    }
}
