using System;
//Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.

namespace tp2ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double faren, cel;
            Console.WriteLine("Ingrese el valor en Fahrenheit: ");
            faren = double.Parse(Console.ReadLine());
            cel = ((faren - 32) / 1.8);
            Console.WriteLine("Celsius: " + cel);
            Console.ReadKey();

        }
    }
}
