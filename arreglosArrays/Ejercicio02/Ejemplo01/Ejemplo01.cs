using System;

namespace GuiaArreglos
{
    class Ejemplo01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Lista de aprobados --");

            string[] aprobados = { "Matias bilotti", "Flores Leandro", "Nohelia Palavecino" };

            Console.WriteLine("Lista de aprobados:");

            foreach (string aprobado in aprobados)
            {
                Console.WriteLine("- " + aprobado);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}