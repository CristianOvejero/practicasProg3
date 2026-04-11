namespace Programa28;

class Program28
{
    static void Main(string[] args)
    {


        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        bool puedeVotar = edad >= 16;

        Console.WriteLine("   Tu edad es: " + edad);
        Console.WriteLine("   ¿Puede votar?: " + puedeVotar);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
     
    }
}
