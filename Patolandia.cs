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
    public partial class Patolandia : Form
    {
        // Cria uma lista vazia de patos
        List<Pato> patos = new List<Pato>();

        public Patolandia()
        {
            InitializeComponent();
        }

        //Botão para criar o pato
        private void btnCriarPato_Click(object sender, EventArgs e)
        {
            //Pegar os valores da tela e atribuir as variáveis
            string nome = txtNome.Text;
            string especie = txtEspecie.Text;
            char genero = cmbGenero.SelectedIndex == 0 ? 'M' : 'F';
            decimal peso = numPeso.Value;
            decimal altura = numAltura.Value;
            // Verifica se a caixa está marcada ou não
            bool cio = ckbEstaCio.Checked;

            //Criar o pato novo
            Pato novo_pato = new Pato(peso, altura, genero, especie, cio);
            novo_pato.nome = nome;

            //Adicionar a lista de patos
            patos.Add(novo_pato);
        }

        //Botão para ver o pato
        private void btnVerPato_Click(object sender, EventArgs e)
        {
            //Seta o pato a partir do numero selecionado
            Pato pato = patos[(int)numNumeroPato.Value];
            txtVisor.Text = pato.ToString();
        }
    }

}
