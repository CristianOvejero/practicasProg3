using System;

namespace GuiaArreglos
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 3: USO DE LENGTH Y BUCLE FOR ---");

            // 1. Inicialización directa
            int[] edades = { 15, 22, 30, 18, 25 };

            // 2. Obtener el tamaño del arreglo dinámicamente
            int cantidadElementos = edades.Length;
            Console.WriteLine("El arreglo tiene " + cantidadElementos + " elementos");

            Console.WriteLine("---------------------------");

            // 3. Bucle for: iteración clásica usando índices
            // i empieza en 0 y va HASTA (pero sin incluir) edades.Length
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Indice " + i + ": La edad es " + edades[i]);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }
}