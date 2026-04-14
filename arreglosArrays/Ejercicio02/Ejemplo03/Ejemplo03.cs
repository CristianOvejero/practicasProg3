using System;

namespace GuiaArreglos
{
    class Ejemplo03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- EJERCICIO: LISTA DE PROVINCIAS CON FOREACH --");

            string[] provincias = { "San Juan", "Mendoza", "Tucuman", "MISIONES" };

            Console.WriteLine("Lista de provincias:");

            foreach (string provincia in provincias)
            {
                Console.WriteLine("- " + provincia);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}