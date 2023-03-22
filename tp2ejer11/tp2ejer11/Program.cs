using System;
//Pide al usuario dos números y muestra la “distancia” entre ellos (el valor absoluto de su diferencia, de
//modo que el resultado sea siempre positivo).

namespace tp2ejer11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, dist;
            Console.Write("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2= int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                dist = numero1 - numero2;
                Console.WriteLine("La distancia entre los dos numeros es: " + dist);
            }
            else
            {
                dist = numero2 - numero1;
                Console.WriteLine("La distancia entre los dos numeros es: " + dist);
            }
        
            Console.ReadKey();
        }
    }
}
