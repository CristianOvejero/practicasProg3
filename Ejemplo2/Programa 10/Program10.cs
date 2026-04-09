namespace Program10;

class Program10
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CALCULAR PORCENTAJE ---");

        Console.Write("Ingresa un número: ");
        double numero = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el porcentaje que desea calcular: ");
        double porcentaje = double.Parse(Console.ReadLine());

        double resultado = numero * porcentaje / 100;

        Console.WriteLine($"El " + porcentaje + " % de " + numero + " es: " + resultado );

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }
}