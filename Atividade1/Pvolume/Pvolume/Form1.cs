using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void calcular(object sender, EventArgs e)
        {
            double raio, altura;

            if (Double.TryParse(txtAltura.Text, out altura) &&
                Double.TryParse(txtRaio.Text, out raio))
            {
                if (altura <= 0 || raio <= 0)
                {
                    MessageBox.Show("Altura e raio devem ser maior que zero");
                    txtAltura.Focus();
                    return;
                }  

                double volume;

                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtResultado.Text = volume.ToString("N2");
                return;
            }

            MessageBox.Show("Altura e raio devem ser numéricos");            
        }

        private void limpar(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtRaio.Text = "";
            txtResultado.Text = "";
            return;
        }

        private void sair(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
