using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string texto = txtOracion.Text;

            // Contar palabras separadas por espacios (ignorando espacios extra)
            int cantidadPalabras = texto
                .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;

            lblResultado.Text = $"Cantidad de palabras: {cantidadPalabras}";
        }
    }
}