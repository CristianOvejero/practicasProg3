using System;

namespace GuiaArreglos
{
    class Ejemplo02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 2: USO BÁSICO DE ARREGLOS ---");

            string[] nombres = new string[3];

            nombres[0] = "Matias Billoti";
            nombres[1] = "Leandro Flores";
            nombres[2] = "Nohelia Palavecino";

            Console.WriteLine("Nombre en índice 0: " + nombres[0]);
            Console.WriteLine("Nombre en índice 1: " + nombres[1]);
            Console.WriteLine("Nombre en índice 2: " + nombres[2]);

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
    }
}