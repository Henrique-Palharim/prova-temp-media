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
        
        /* --------------- RECURSOS --------------- */

        private void numNota1_Enter(object sender, EventArgs e)
        {
            string nota1Formatado = numNota1.Value.ToString("0.00");
            numNota1.Select(0, nota1Formatado.Length);
        }

        private void numNota2_Enter(object sender, EventArgs e)
        {
            string nota2Formatado = numNota2.Value.ToString("0.00");
            numNota2.Select(0, nota2Formatado.Length);
        }

        private void numNota3_Enter_1(object sender, EventArgs e)
        {
            string nota3Formatado = numNota3.Value.ToString("0.00");
            numNota3.Select(0, nota3Formatado.Length);
        }
    }
}
