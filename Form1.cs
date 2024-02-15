using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Form1 : Form
    {
        Pato meu_pato;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarPato_Click(object sender, EventArgs e)
        {
            meu_pato = new Pato(3, 0.40m, 'M', "Pato real", true);

            meu_pato.nome = "Jeremias";

            txtVisor.Text = meu_pato.nome.ToString();
        }

        private void btnTempoVida_Click(object sender, EventArgs e)
        {
            // Se existir um pato
            if (meu_pato != null)
            {
                txtVisor.Text = meu_pato.getTempoVida().ToString();
            }
        }

        private void btnMataPato_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                $"Deseja matar o {meu_pato.nome}?", 
                "Matar Pato", 
                MessageBoxButtons.YesNo
            );

            if (resposta == DialogResult.Yes)
            {
                meu_pato.Grasnar();
                meu_pato = null;
            }
            else
            {
                meu_pato.Grasnar();
            }
        }
    }
}
