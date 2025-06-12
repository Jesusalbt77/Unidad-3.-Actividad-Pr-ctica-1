using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbde_SelectedIndexChanged(object sender, EventArgs e)
        {

       

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (cmbde.SelectedItem.ToString() == "Pulgada" & cmba.SelectedItem.ToString() == "Centimetro" )
            {
                double conversion;
                conversion = int.Parse(txtvalor.Text) * 2.54;
                txtresultado.Text = conversion.ToString();

            }
            else
                  if (cmbde.SelectedItem.ToString() == "Centimetro" & cmba.SelectedItem.ToString() == "Metro")
            {
                double conversion;
                conversion = int.Parse(txtvalor.Text) * 0.01;
                txtresultado.Text = conversion.ToString();

            }
            else
            {
                if (cmbde.SelectedItem.ToString() == "Metro" & cmba.SelectedItem.ToString() == "Pulgada")
            {
                double conversion;
                conversion = int.Parse(txtvalor.Text) * 39.3700787;
                txtresultado.Text = conversion.ToString();

                }
                else
                {
                    if (cmbde.SelectedItem.ToString() == "Metro" & cmba.SelectedItem.ToString() == "Metro")
                    {
                        double conversion;
                        conversion = int.Parse(txtvalor.Text) * 1;
                        txtresultado.Text = conversion.ToString();

                    }
                    else
                    {
                        if (cmbde.SelectedItem.ToString() == "Pulgada" & cmba.SelectedItem.ToString() == "Metro")
                        {
                            double conversion;
                            conversion = int.Parse(txtvalor.Text) * 0.0254;
                            txtresultado.Text = conversion.ToString();

                        }
                        else
                        {
                            if (cmbde.SelectedItem.ToString() == "Pulgada" & cmba.SelectedItem.ToString() == "Pulgada")
                            {
                                double conversion;
                                conversion = int.Parse(txtvalor.Text) * 1;
                                txtresultado.Text = conversion.ToString();

                                
                            }
                            else
                            {
                                if (cmbde.SelectedItem.ToString() == "Centimetro" & cmba.SelectedItem.ToString() == "Pulgada")
                                {
                                    double conversion;
                                    conversion = int.Parse(txtvalor.Text) * 0.39370079;
                                    txtresultado.Text = conversion.ToString();
                                }
                                else
                                {
                                    if (cmbde.SelectedItem.ToString() == "Metro" & cmba.SelectedItem.ToString() == "Centimetro")
                                    {
                                        double conversion;
                                        conversion = int.Parse(txtvalor.Text) * 100;
                                        txtresultado.Text = conversion.ToString();

                                    }
                                    else
                                    {
                                        if (cmbde.SelectedItem.ToString() == "Centimetro" & cmba.SelectedItem.ToString() == "Centimetro")
                                        {
                                            double conversion;
                                            conversion = int.Parse(txtvalor.Text) * 1;
                                            txtresultado.Text = conversion.ToString();
                                        }
                                    }
                                }
                            }
                        }

                        }

                }
                    
            }
        }
    }
}
