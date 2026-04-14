namespace Programa39;

class Program39
{
    static void Main(string[] args)
    {
        const decimal AUMENTO1 = 0.05m;
        const decimal AUMENTO2 = 0.1m;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- TU SUELDO CON LOS PROXIMOS AUMENTOS ---");
        Console.Write("Ingresa tu sueldo actual: ");
        decimal sueldo = decimal.Parse(Console.ReadLine());

        Console.WriteLine("---CON LOS SIGIENTES 2 AUMENTOS TU SUELDO SERA DE:---");

        decimal calcAux1 = sueldo + (sueldo * AUMENTO1);
        decimal sueldoA1 = calcAux1;

        decimal calcAux2 = sueldo + (sueldo * AUMENTO2);
        decimal sueldoA2 = calcAux2;

        Console.WriteLine("Sueldo final con el primer aumento= " + SIMBOLO_PESO + sueldoA1);
        Console.WriteLine("Sueldo final con el suegndo aumento= " + SIMBOLO_PESO + sueldoA2);


    }
}


