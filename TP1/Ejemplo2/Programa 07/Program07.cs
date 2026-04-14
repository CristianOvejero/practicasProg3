namespace Program06;

class Program06
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- >REGISTRA TU CUENTA ---");

        Console.Write("Por favor, ingresa tu nombre de usuario: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa tu contraseña: ");
        string contraseña = Console.ReadLine();


        Console.WriteLine("--- CUENTA CREADA ---");
        Console.WriteLine("Nombre de usuario: " + nombre);
        Console.WriteLine("Contraseña: " + contraseña);


        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }
}
