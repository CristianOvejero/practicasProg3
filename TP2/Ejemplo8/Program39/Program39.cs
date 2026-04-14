namespace Programa39;

class Program39
{
    static void Main(string[] args)
    {
        const decimal DESCUENTO10 = 0.10m;
        const decimal DESCUENTO20 = 0.20m;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- CALCULA TUS DESCUENTOS ---");

        Console.Write("Ingresa el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        decimal calcAux1 = precio - (precio * DESCUENTO10);
        decimal precioF1 = calcAux1;

        decimal calcAux2 = precio - (precio * DESCUENTO20);
        decimal precioF2 = calcAux2;

        Console.WriteLine("Precio original: " + SIMBOLO_PESO + precio);

        Console.WriteLine("--- CON DESCUENTO 10% ---");
        Console.WriteLine("Precio final: " + SIMBOLO_PESO + precioF1);

        Console.WriteLine("--- CON DESCUENTO 20% ---");
        Console.WriteLine("Precio final: " + SIMBOLO_PESO + precioF2);
    }
}