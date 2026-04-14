using System;

namespace GuiaArreglos
{
    class Ejemplo01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 2: USO BÁSICO DE ARREGLOS ---");

            int[] edades = new int[5];

            edades[0] = 21;
            edades[1] = 25;
            edades[2] = 30;
            edades[3] = 31;
            edades[4] = 35;

            Console.WriteLine("Edad en índice 0: " + edades[0]);
            Console.WriteLine("Edad en índice 1: " + edades[1]);
            Console.WriteLine("Edad en índice 2: " + edades[2]);
            Console.WriteLine("Edad en índice 3: " + edades[3]);
            Console.WriteLine("Edad en índice 4: " + edades[4]);


            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
    }

}

