using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    //Criando uma subclasse a partir da classe Forma
    class Retangulo : Forma
    {
        //Criando a variavel para a Largura e fazendo o encapsulamento
        public double Largura { get; set; }
        //Criando a variavel para a Altura e fazendo o encapsulamento
        public double Altura { get; set; }

        //Criando um construtor e colocando os valores certos nele
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            //Igualando o valor da variavel largura da forma com a do construtor
            Largura = largura;
            //Igualando o valor da variavel altura da forma com a do construtor
            Altura = altura;
        }
        //Reescrevendo o método para calcular a área corretamente do retângulo
        public override double Area()
        {
            //Calculo da área do retângulo
            return Largura * Altura;
        }
    }
}