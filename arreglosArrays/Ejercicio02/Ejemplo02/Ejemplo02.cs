using System;

namespace GuiaArreglos
{
    class Ejemplo02

    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- COMPUNOR STOCK CATEGORIAS --");

            string[] componentes = { "RAM", "SSD", "Procesadores", "Motherboards" };


            foreach (string componente in componentes)
            {
                Console.WriteLine("- " + componente);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}