using System;
//- Escribir un programa que pregunte al usuario su nombre, y luego lo salude.
namespace tp2ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.ReadKey();

        }
    }
}
