namespace Programa29;

class Program29
{
    static void Main(string[] args)
    {


        Console.Write("Ingrese la temperatura actual: ");
        int temperatura = int.Parse(Console.ReadLine());

        bool haceCalor = temperatura >= 30;

        Console.WriteLine("   La temperatura es: " + temperatura);
        Console.WriteLine("   ¿Hace calor?: " + haceCalor);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}
