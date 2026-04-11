namespace Program34;

class Program34
{
    static void Main(string[] args)
    {
        const string NOMBRE_APP = "Numero mayor a 7";
        const int NUMERO = 7;

        Console.WriteLine("=== " + NOMBRE_APP + " ===");

        Console.Write("Ingresa un numero mayor a 7: ");
        int numero = int.Parse(Console.ReadLine());

        bool numeroIngresado = numero > NUMERO;

        Console.WriteLine("Intresaste el numero " + numero);
        Console.WriteLine("¿Es mayor a " + NUMERO +"?: " + numeroIngresado);

        Console.WriteLine("Presiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
    