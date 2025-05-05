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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btTemperatura_Click(object sender, EventArgs e)
        {
            // abrir o formulário do exercício de temperatura
            frmTemperatura temperatura = new frmTemperatura();
            temperatura.Show();
        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            // abrir o formulário do exercício de cálculo de média
            frmCalculaMedia media = new frmCalculaMedia();
            media.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja Sair da Aplicação ?",
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
    }
}
