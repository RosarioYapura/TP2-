using System;
//mostrar el area y perimetro de un hexagono
namespace tp2ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado, perim, area, diam;
            Console.WriteLine("Ingrese el valor de un lado de el hexagono: ");
            lado = Convert.ToInt32(Console.ReadLine());
            perim = 6 * lado;
            Console.WriteLine("Perimetro: " + perim);
            Console.WriteLine("Ingresar el diametro de el hexagono: ");
            diam = Convert.ToInt32(Console.ReadLine());
            area = (perim * diam) / 2;
            Console.WriteLine("Area: " + area);
            Console.ReadKey();
                
        }

    }
}
