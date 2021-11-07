using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    //Criando uma classe abstrata Forma
    abstract class Forma
    {
        //Criando uma variavel do tipo color e fazendo o encapsulamento
        public Color Color { get; set; }
        //Criando um construtor e colocando a cor certa nele
        public Forma (Color color)
        {
            //Igualando a cor da forma com a cor do enum
            Color = color;
        }
        //Criando um método para calcular a área
        public abstract double Area();
    }
}
