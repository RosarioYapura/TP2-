using System;
//- Realizar un programa que lea un número y que muestre su raíz cuadrada y su raíz cúbica. C# tiene
//función que permita calcular la raíz cuadrada cúbica. ¿Cómo se puede calcular?

namespace tp2ejer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, raizcua,raizcu;
            Console.WriteLine("Ingrese el numero: ");
            num = double.Parse(Console.ReadLine());
            raizcua = Math.Sqrt(num);
            Console.WriteLine("La raiz cuadrada de: " + num + " es: " + raizcua);
            raizcu = Math.Pow(num, 1.0 / 3.0);
            Console.WriteLine("La raiz cubica de: " + num + " es: " + raizcu);
            Console.ReadKey();
        }
    }
}
