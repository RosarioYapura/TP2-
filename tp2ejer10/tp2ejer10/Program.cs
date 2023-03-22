using System;
//Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuánto
//deberá pagar finalmente por su compra.

namespace tp2ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double desc, compra, total;
            Console.Write("Ingrese el monto de su compra: $");
            compra = double.Parse(Console.ReadLine());
            desc = (compra * 15) / 100;
            total = compra - desc;
            Console.WriteLine("El descuento de 15% es de: $" + desc);
            Console.WriteLine("Total final con descuento: $" + total);
            Console.ReadKey();
        }
    }
}
