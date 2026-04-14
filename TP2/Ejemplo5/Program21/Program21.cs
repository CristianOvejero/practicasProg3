namespace Program21;

class Program21
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

        string nombre = "Camila Perez";
        Console.WriteLine("4. TIPO TEXTO (string):");
        Console.WriteLine("   Valor guardado: " + nombre);

        // Carácter único (char) - Comillas simples ''
        char inicialNombre = 'C';
        Console.WriteLine("\n5. TIPO CARÁCTER (char):");
        Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}