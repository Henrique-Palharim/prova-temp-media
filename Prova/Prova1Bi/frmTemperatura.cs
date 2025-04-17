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
    public partial class frmTemperatura : Form
    {

        /* --------------- COMPONENTES --------------- */

        public frmTemperatura()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            numTemp.Value = 0;
            numAcrescimoTemp.Value = 0;

            lblResultado.Text = "";
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double temperatura = (double)numTemp.Value;
            double acrescimo = (double)numAcrescimoTemp.Value;

            double resultado = Acrescimo(temperatura, acrescimo);

            lblResultado.Text = resultado.ToString("0.00"); // exibe como "1.00" se for só o valor do acréscimo
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTemperatura_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente Sair ?",
                                       "Temperatura 1° Bimestre",
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

        private double Acrescimo(double temperatura, double acrescimo)
        {
            return temperatura + (temperatura * acrescimo / 100);
        }

        
    }
}
