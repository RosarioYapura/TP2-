using System;
//- Hacer un programa que calcule el salario de un empleado, si se descuenta el 20% de su salario bruto.
namespace tp2ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salario;
            decimal totala;
            decimal total2;
            Console.WriteLine("Ingrese su salario: ");
            salario = decimal.Parse(Console.ReadLine());
            totala = (20 * salario) / 100;
            total2 = salario - totala;
            Console.WriteLine("Su salario menos el 20% de ingresos brutos es: $" + total2);
            Console.ReadKey();
        }
    }
}
