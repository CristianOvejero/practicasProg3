using System;

namespace GuiaArreglos
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- EJERCICIO 2: INICIALIZACIÓN DIRECTA Y FOREACH --");

            // 1. Inicialización directa
            string[] frutas = { "Manzana", "Banana", "Uva", "Naranja" };

            Console.WriteLine("Lista de frutas usando foreach:");

            // 2. Bucle foreach
            foreach (string fruta in frutas)
            {
                Console.WriteLine("- " + fruta);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}