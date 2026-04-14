using System;

namespace GuiaArreglos
{
    class Ejemplo03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Categorias stock de productos ---");

            string[] productos = { "bebidas" , "comestibles" , "articulos limpieza" , "cigarrillos" };

            int cantidadElementos = productos.Length;
            Console.WriteLine("Cantigada de categorias " + cantidadElementos );

            Console.WriteLine("---------------------------");

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine(  (i + 1) + "°- Categoria: " + productos[i]);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}