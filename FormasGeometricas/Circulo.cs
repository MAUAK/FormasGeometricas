using System;
using Course.Entities.Enums;
namespace Course.Entities
{
    //Criando uma subclasse a partir da classe Forma
    class Circulo : Forma
    {
        //Criando a variavel para o raio e fazendo o encapsulamento
        public double Raio { get; set; }
        //Criando um construtor e colocando os valores certos nele
        public Circulo(double raio, Color cor) : base(cor)
        {
            //Igualando o valor da variavel raio da forma com a do construtor
            Raio = raio;
        }
        //Reescrevendo o método para calcular a área corretamente do circulo
        public override double Area()
        {
            //Calculo da área do circulos
            return Math.PI * Raio * Raio;
        }
    }
}
