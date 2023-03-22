using System;
//Un ciclista parte de una ciudad A a las HH horas, MM minutos y SS segundos. El tiempo de viaje hasta
//llegar a otra ciudad B es de T segundos. Escribir un algoritmo que determine la hora de llegada a la ciudad B.

namespace tp2ejer14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HH,MM,SS, tiempo, totalseg,segrest;
            Console.WriteLine("Ingrese la hora de salida: ");
            HH = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos de salida: ");
            MM = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos de salida: ");
            SS = int.Parse(Console.ReadLine());
            Console.WriteLine("Duracion del viaje en segundos: ");
            tiempo = int.Parse(Console.ReadLine());
            totalseg = HH * 3600 + MM * 60 + SS + tiempo;
            HH = totalseg / 3600;
            segrest = totalseg % 3600;
            MM = segrest / 60;
            SS = segrest % 60;
            Console.WriteLine("La hora de llegada a la ciudad B sera: " + HH + ":" + MM + ":" + SS);
            Console.ReadKey();
        }
    }
}
