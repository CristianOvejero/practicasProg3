using System;

namespace GuiaArreglos
{
    class Ejemplo04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- EJERCICIO: LISTA DE ALTURAS CON FOREACH --");

            double[] alturas = { 1.65, 1.72, 1.80, 1.58 };

            Console.WriteLine("Lista de alturas:");

            foreach (double altura in alturas)
            {
                Console.WriteLine("- " + altura + " m");
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}