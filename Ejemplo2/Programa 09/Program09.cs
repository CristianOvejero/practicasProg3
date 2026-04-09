namespace Program09;

class Program09
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- AÑO DE NACIMIENTO ---");

   
        Console.Write("Ingresa tu edad: ");
        string edadTexto = Console.ReadLine();
        int edad = int.Parse(edadTexto);


        int anioActual = 2026;
        int nacimiento = anioActual - edad;

        Console.WriteLine($"Tu año de nacimiento es "  + nacimiento);

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }
}


