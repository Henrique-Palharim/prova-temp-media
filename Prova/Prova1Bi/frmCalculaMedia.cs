using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova1Bi
{
    public partial class frmCalculaMedia : Form
    {

        /* --------------- COMPONENTES --------------- */

        public frmCalculaMedia()
        {
            InitializeComponent();
        }

        private void btZerar_Click(object sender, EventArgs e)
        {
            numNota1.Value = 0;
            numNota2.Value = 0;
            numNota3.Value = 0;

            lblMedia.Text = string.Empty;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double n1 = (double) numNota1.Value;
            double n2 = (double) numNota2.Value;
            double n3 = (double) numNota3.Value;

            lblMedia.Text = CalcularMedia(n1, n2, n3).ToString();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculaMedia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente Sair ?",
                                       "Calcular Média 1° Bi",
                                       MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        /* --------------- FUNÇÕES --------------- */

        private double CalcularMedia(double a, double b, double c)
        {
            double media = (a + b + c) / 3;
            return media;
        }

        
    }
}
