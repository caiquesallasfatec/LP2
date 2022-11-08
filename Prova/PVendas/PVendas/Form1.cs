using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux;
            double somaMes = 0.0;
            double somaAno = 0.0;

            double[ , ] N = new double[9, 4];

            for (int i = 0; i < 9; i++) {
                for (int x = 0; x < 4; x++) {
                    try
                    {
                        N[i, x] = Double.Parse(Interaction.InputBox("Insira o valor do mês " + (i + 1) + " na semana " + (x + 1)).ToString());
                    }
                    catch (Exception excessao)
                    {
                        MessageBox.Show("Dados invalidos");
                        x--;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                somaMes = 0.0;
                for (int x = 0; x < 4; x++)
                {
                    listBox.Items.Add("Total do mês: " + (i + 1) + " Semana: " + (x + 1) + " " + N[i, x].ToString("N2"));
                    somaMes += N[i, x];
                    somaAno += N[i, x];
                }

                listBox.Items.Add(">> Total Mês:" + somaMes.ToString("N2"));
                listBox.Items.Add("-----------------------------------");
            }
            listBox.Items.Add(">> Total Geral:" + somaAno.ToString("N2"));            
        }
    }
}
