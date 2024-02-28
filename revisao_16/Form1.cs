using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_calcular_Click(object sender, EventArgs e)
        {
            imc objimc = new imc();
                try
                {
                    objimc.Altura = double.Parse(txt_altura.Text);
                    objimc.Peso = double.Parse(txt_peso.Text);
                    MessageBox.Show("Seu IMC é: " + objimc.CalcularIMC().ToString("0.00") + "\n" + objimc.TabelaIMC());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error. \n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n " + ex.Message);
                }

            
        }
    }

}

