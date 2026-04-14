using System;

namespace GuiaArreglos 
{
    class Ejercicio05 
    {
        static void Main(string[] args) 
        {
            string[] nombres = new string[3];

            Console.Write("Ingresa nombre 1: ");
            nombres[0] = Console.ReadLine();

            Console.Write("Ingresa nombre 2: ");
            nombres[1] = Console.ReadLine();

            Console.Write("Ingresa nombre 3: ");
            nombres[2] = Console.ReadLine();

            Console.WriteLine("------------------------");


            Console.WriteLine("Nombre en índice 0: " + nombres[0]);
            Console.WriteLine("Nombre en índice 1: " + nombres[1]);
            Console.WriteLine("Nombre en índice 2: " + nombres[2]);

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
    }
}