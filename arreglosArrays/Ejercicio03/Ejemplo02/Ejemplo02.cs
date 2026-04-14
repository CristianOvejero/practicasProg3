using System;

namespace GuiaArreglos
{
    class Ejemplo01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 3: USO DE LENGTH Y BUCLE FOR ---");

            int[] notas = { 4, 6, 2, 7, 9 };

            int cantidadElementos = notas.Length;
            Console.WriteLine("La candidad de alumnos que rindieron es " + cantidadElementos + " y sus notas son:");

            Console.WriteLine("---------------------------");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Alumno " + (i + 1) + ": Su nota es " + notas[i]);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}