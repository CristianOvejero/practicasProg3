namespace Programa33;

class Program33
{
    static void Main(string[] args)
    {
        const string NOMBRE_APP = "Montaña rusa";
        const double ALTURA_MINIMA = 150;

        Console.WriteLine("=== " + NOMBRE_APP + " ===");
        Console.WriteLine("Restricción: Altura mínima de " + ALTURA_MINIMA + " centimetros.");

        Console.Write("Ingrese su altura en centimetros por favor ");
        double alturaCliente = double.Parse(Console.ReadLine());

        bool puedeIngresar = alturaCliente >= ALTURA_MINIMA;

        Console.WriteLine("Tu altura es: " + alturaCliente + " m");
        Console.WriteLine("¿Puede ingresar?: " + puedeIngresar);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
