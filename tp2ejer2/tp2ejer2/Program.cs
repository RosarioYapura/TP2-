using System;
//- Calcular el cambio de monedas en dólares y euros al ingresar cierta cantidad de dinero en pesos.

namespace tp2ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pesos;
            int dolares;
            int euro;
           decimal total1;
           decimal total2;
            dolares = 380;
            euro = 450;
            Console.WriteLine("Ingrese la cantidad de $: ");
                pesos = Convert.ToDecimal(Console.ReadLine());
            total1 = pesos / dolares; total2 = pesos / euro;
            Console.WriteLine("Dolares: " + total1);
            Console.WriteLine("Euros: " + total2);
            Console.ReadKey();
        }
    }
}
