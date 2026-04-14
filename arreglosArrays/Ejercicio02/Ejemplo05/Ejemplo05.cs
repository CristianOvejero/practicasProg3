using System;

namespace GuiaArreglos
{
    class Ejemplo05

    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- EJERCICIO: INTERESES POR CUOTAS --");

            int[] cuotas = { 3, 6, 9, 12 };
            int[] intereses = { 20, 30, 40, 50 }; 

            Console.WriteLine("Intereses en cuotas:");

            int i = 0;
            foreach (int cuota in cuotas)
            {
                Console.WriteLine("- " + cuota + " cuotas: " + intereses[i] + "% de interes");
                i++;
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}