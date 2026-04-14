using System;

namespace GuiaArreglos
{
    class Ejemplo04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 2: USO BÁSICO DE ARREGLOS ---");

            char[] letras = new char[3];

            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'c';

            Console.WriteLine("Letra en índice 0: " + letras[0]);
            Console.WriteLine("Letra en índice 1: " + letras[1]);
            Console.WriteLine("Letra en índice 2: " + letras[2]);

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
    }
}