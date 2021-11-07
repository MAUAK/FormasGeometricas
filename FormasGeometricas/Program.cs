using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma lista de formas
            List<Forma> list = new List<Forma>();
            //Pedindo e lendo o número de formas que irão existir
            Console.WriteLine("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            //Criando uma estrutura de retição para colocar os valores das formas
            for (int i = 1; i <= n; i++)
            {
                //Imprimindo a posição da forma que receberá os valores
                Console.WriteLine($"Forma #{i}: ");
                //Pedindo e verificando se é um retângulo ou circulo
                Console.Write("Retângulo ou Circulo (R/C)? ");
                char ch = char.Parse(Console.ReadLine());
                //Pedindo e verificando qual a cor da forma
                Console.Write("Cor: (Preto/Azul/Vermelho): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());

                //Veificando se é um retângulo
                if (ch == 'R')
                {
                    //Pedindo a largura da forma e guardando ela em uma variavel
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Pedindo a altura da forma e guardando ela em uma variavel
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Adicionando na lista esta forma com seus valores
                    list.Add(new Retangulo(largura, altura, cor));
                }
                //Se não for um retângulo, será um circulo
                else
                {
                    //Pedindo o raio da forma e guardando ela em uma variavel
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Adicionando na lista esta forma com seus valores
                    list.Add(new Circulo(raio, cor));
                }
                //Pulando linha
                Console.WriteLine();
            }
            //Escrevendo as áreas de cada forma
            Console.WriteLine("Área de cada forma: ");
            //Para cada intem da lista
            foreach (Forma forma in list)
            {
                //Escreveer a sua área!
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}