using System;
//Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, el vendedor desea
//saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total
//que recibirá en el mes tomando en cuenta su sueldo base y comisiones.

namespace tp2ejer9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo=80000, venta1, venta2, venta3, total;
            Console.WriteLine("Su sueldo base es de: " + sueldo);
            Console.WriteLine("Venta n1: ");
            venta1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Venta n2: ");
            venta2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Venta n3: ");
            venta3 = double.Parse(Console.ReadLine());
            venta1 = (venta1 * 10) / 100;
            venta2 = (venta2 * 10) / 100;
            venta3 = (venta3 * 10) / 100;
            total = sueldo + venta1 + venta2 + venta3;
            Console.WriteLine("Su sueldo mas el 10% de cada venta es: " + total);
            Console.ReadKey();
        }
    }
}
