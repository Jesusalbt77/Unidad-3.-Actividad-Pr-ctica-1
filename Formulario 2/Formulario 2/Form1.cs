using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxLongitud_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int longitudPass = int.Parse(tbLongitud.Text);

            Random random = new Random();

            string cadena = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";

            char[] Password = new char[longitudPass];

            for (int i = 0; i < longitudPass; i++) { 

                int indice = random.Next(cadena.Length);
                Password[i] = cadena[indice];
            }
            string NuevoPass = new string(Password);
            tbGenerada.Text = NuevoPass;
        }
    }
}
