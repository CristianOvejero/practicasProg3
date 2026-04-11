namespace Programa27;

class Program27
{
    static void Main(string[] args)
    {


        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        bool esMayor = edad >= 18;

        Console.WriteLine("   Tu edad es: " + edad);
        Console.WriteLine("   ¿Es mayor de edad?: " + esMayor);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
