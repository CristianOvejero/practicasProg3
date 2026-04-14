namespace Programa30;

class Program30
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la contraseña: ");
        string contraseña = Console.ReadLine();

        bool correcta = contraseña == "1234";

        Console.WriteLine("   Contraseña ingresada: " + contraseña);
        Console.WriteLine("   ¿La contraseña es correcta?: " + correcta);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}