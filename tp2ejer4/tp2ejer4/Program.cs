using Microsoft.Win32.SafeHandles;
using System;
//Hacer un programa que ingrese por teclado un número total de segundos y que luego pueda mostrar la
//cantidad de horas, minutos y segundos que existen en el valor ingresado.
namespace tp2ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double segundos;
            double minutos;
            double horas;
            Console.WriteLine("Ingrese la cantidad de segundos: ");
            segundos = Convert.ToDouble(Console.ReadLine());
            minutos = segundos / 60;
            horas = minutos / 60;
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Horas: " + horas);
            Console.ReadKey();
        }
    }
}
