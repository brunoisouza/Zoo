using System;
using System.Windows.Forms;

namespace Zoo
{
    //Criação da Classe
    internal class Pato
    {
        //Atributos da classe
        public string nome;
        public decimal peso { get; }
        public decimal altura { get; }
        public char genero { get; }
        public string especie { get; set; }
        public bool cio { get; }

        private DateTime data_nascimento;

        private int nivel_medo;

        // Metodo Construtor da Classe
        public Pato(decimal peso, decimal altura, char genero, string especie, bool cio)
        {
            this.peso = peso;
            this.altura = altura;
            this.genero = genero;
            this.especie = especie;
            this.cio = cio;

            this.data_nascimento = DateTime.Now;
            this.nivel_medo = 0;

            this.Grasnar();
        }
        
        //Como a classe vai se comportar ao se transformar em texto
        public override string ToString()
        {
            return $"Olá, eu sou {this.nome} e tenho {this.getTempoVida()}. Atualmente, " +
                $"peso {this.peso} e tenho {this.altura} de tamanho. Ahhh, " +
                $"eu {(this.cio ? "" : "não")} estou no cio.";
        }
        
        //Função para Pegar o tempo de vida
        public string getTempoVida()
        {
            TimeSpan tempo_vida = DateTime.Now - this.data_nascimento;
            return tempo_vida.ToString("c");
        }
        
        //Função para o pato grasnar
        public void Grasnar()
        {
            if (nivel_medo ==  0)
            {
                MessageBox.Show("Quack");
            } 
            else if (nivel_medo > 0)
            {
                MessageBox.Show("Quack!");
            }
            else if (nivel_medo > 5)
            {
                MessageBox.Show("Quaaaaaaaaaaaaaaaaaack!");
            }
        }
    }
}
