namespace Programa32;

class Program32
{
    static void Main(string[] args)
    {
        const string NOMBRE_APP = "GameMaster Pro";
        const int EDAD_MINIMA = 18;

        Console.WriteLine("=== " + NOMBRE_APP + " ===");
        Console.WriteLine("Restricción: Mayores de " + EDAD_MINIMA + " años.");

        Console.Write("Ingrese su edad: ");
        int edadCliente = int.Parse(Console.ReadLine());

        bool puedeIngresar = edadCliente >= EDAD_MINIMA;

        Console.WriteLine("Tu edad es: " + edadCliente);
        Console.WriteLine("¿Puede ingresar?: " + puedeIngresar);

        Console.WriteLine("Presiona ENTER para cerrar.");
        Console.ReadLine();

    }
}