using System;

namespace GuiaArreglos
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 1: FUNDAMENTOS DE ARREGLOS ---");

            // 1. Declaración e inicialización de un arreglo
            // Los valores por defecto son 0
            int[] numeros = new int[3];

            // 2. Asignación de valores manual por índice
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;

            // 3. Acceso y lectura de valores
            Console.WriteLine("Valor en índice 0: " + numeros[0]);
            Console.WriteLine("Valor en índice 1: " + numeros[1]);
            Console.WriteLine("Valor en índice 2: " + numeros[2]);

            // 4. Intento de acceso a un índice inválido
            // numeros[3] = 40; // IndexOutOfRangeException

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
    }
}