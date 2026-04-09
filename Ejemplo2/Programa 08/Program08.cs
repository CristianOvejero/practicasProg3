namespace Program08;

class Program08
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- RESTA DOS NUMEROS ---");

        Console.Write("Por favor, ingresa un numero ");
        string numTexto = Console.ReadLine();
        int num1 = int.Parse(numTexto);
        Console.Write("Por favor, ingresa el segundo numero ");
        string numTexto2 = Console.ReadLine();
        int num2 = int.Parse(numTexto2);
        int numResultado = num1 -+ num2;

        Console.WriteLine("El resultado de " + num1 + " - " + num2 + " es: " + numResultado);
        

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }
}
