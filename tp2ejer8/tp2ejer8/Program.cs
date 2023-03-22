using System;
//Mostrar el área y perímetro de un paralelogramo.
namespace tp2ejer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float area, perim;
            float alt, basse , a;
            Console.WriteLine("Ingrese el lado 'a': ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la base: ");
            basse = float.Parse(Console.ReadLine());
            perim = 2 * (basse + a);
            Console.WriteLine("Perimetro: " + perim);
            Console.WriteLine("Ingrese la altura: ");
            alt = float.Parse(Console.ReadLine());
            area = basse * alt;
            Console.WriteLine("area: " + area);

            Console.ReadLine();
        }
    }
}
