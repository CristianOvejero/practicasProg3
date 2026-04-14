namespace Programa33;

class Program33
{
    static void Main(string[] args)
    {
        const string NOMBRE_JUEGO = "Montaña rusa";
        const double ALTURA_MINIMA = 150;

        Console.WriteLine("=== " + NOMBRE_JUEGO + " ===");
        Console.WriteLine("Restricción: Altura minima de " + ALTURA_MINIMA + " centimetros.");

        Console.Write("Ingresa tu altura en centimetros por favor ");
        double altura = double.Parse(Console.ReadLine());

        bool puedeIngresar = altura >= ALTURA_MINIMA;

        Console.WriteLine("Tu altura es: " + altura + " m");
        Console.WriteLine("¿Puede ingresar?: " + puedeIngresar);

        Console.WriteLine("Presiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
