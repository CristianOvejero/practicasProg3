using System;

namespace GuiaArreglos
{
    class Ejemplo03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 2: USO BÁSICO DE ARREGLOS ---");

            double[] alturas = new double[3];

            alturas[0] = 1.80;
            alturas[1] = 1.98;
            alturas[2] = 1.65;

            Console.WriteLine("Altura en índice 0: " + alturas[0]);
            Console.WriteLine("Altura en índice 1: " + alturas[1]);
            Console.WriteLine("Altura en índice 2: " + alturas[2]);

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();

        }
    }
}