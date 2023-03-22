using System;
//Dado un número de dos cifras, diseñe un programa que permita obtener el número invertido. Ejemplo,
//si se introduce 23 que muestre 32.
namespace tp2ejer13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cociente, residuo,invertido;
            Console.WriteLine("Ingrese un numero de dos cifras: ");
            num = int.Parse(Console.ReadLine());
             residuo= (num%10);
            cociente = (num / 10);
            invertido = (residuo * 10) + cociente;
            Console.WriteLine("El numero invertido es: "+invertido);
            Console.ReadKey();
        }
    }
}
