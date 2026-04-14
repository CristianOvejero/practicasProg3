namespace Program34;

class Program34
{
    static void Main(string[] args)
    {
        const string PRUEBA = "Evaluativo";
        const int NOTA_MINIMA = 6;

        Console.WriteLine("=== " + PRUEBA + " ===");
        Console.WriteLine("Restricción: Nota minima para aprobar: " + NOTA_MINIMA);

        Console.Write("Ingrese su nota: ");
        int notaAlumno = int.Parse(Console.ReadLine());

        bool aprueba = notaAlumno >= NOTA_MINIMA;

        Console.WriteLine("ttu nota es: " + notaAlumno);
        Console.WriteLine("¿Aprueba?: " + aprueba);

        Console.WriteLine("Presiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
