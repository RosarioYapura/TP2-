using System;
using System.Runtime.InteropServices;
//Mostrar el área y perímetro de un rombo.
namespace tp2ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {   float D;
            float d;
            float area;
            float perimetro;
            Console.WriteLine("Ingrese D:");
            D = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Ingrese d: ");
            d = Convert.ToSByte(Console.ReadLine());
            perimetro = (2 * D) + (2 * d);
            area = (D * d) / 2;
            Console.WriteLine("El area del rombo es: " + area);
            Console.WriteLine("El perimestro del rombo es: " + perimetro);
            Console.ReadKey();
        }  
    }
}
