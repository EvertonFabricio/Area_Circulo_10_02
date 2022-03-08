using System;

namespace Area_Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a medida, em centimetros, do raio de um circulo qualquer: ");
            float raio = float.Parse(Console.ReadLine());
         
            Console.WriteLine($"\nA area de um circulo de raio igual a {raio} centimetros é {raio*raio*3.14} centimetros quadrados");


        }
    }
}
