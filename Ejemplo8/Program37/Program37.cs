namespace Programa37;

class Program37
{
    static void Main(string[] args)
    {
        const decimal INTERES3 = 0.10m;
        const decimal INTERES6 = 0.20m;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- CALCULADORA DE CUOTAS ---");

        Console.Write("Ingresa el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        decimal calcAux1 = precio + (precio * INTERES3);
        decimal cuota3 = calcAux1 / 3;


        decimal calcAux2 = precio + (precio * INTERES6);
        decimal cuota6 = calcAux2 / 6;


        Console.WriteLine("Precio original: " + SIMBOLO_PESO + precio);

        Console.WriteLine("--- 3 CUOTAS (10% interes) ---");
        Console.WriteLine("Cada cuota de: " + SIMBOLO_PESO + cuota3);

        Console.WriteLine("--- 6 CUOTAS (20% interes) ---");
        Console.WriteLine("Cada cuota de: " + SIMBOLO_PESO + cuota6);
    }
}