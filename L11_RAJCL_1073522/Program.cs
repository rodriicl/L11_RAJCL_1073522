class Program
{
    static void Main(string[] args)
    {

        int Moneda;
        double Monto;
        Console.WriteLine("Convertidor de monedas a Euros");
        Console.WriteLine("Para convertir de libras ingrese 1, dolares ingrese 2 y yenes ingrese 3");
        Moneda = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad a convertir");

        Monto = Convert.ToDouble(Console.ReadLine());
        
        double resultado = conversionMoneda(Moneda, Monto);
        Console.WriteLine("Su cantidad en Euros es: " + resultado);
 
    }


    private static double conversionMoneda(int Moneda, double Monto)
    {
  
        if (Moneda == 1)
        {
            return Monto * 1.22;
        }

    
        if (Moneda == 2)
        {
            return Monto * 0.75;
        }

        if (Moneda == 3)    
        {
            return Monto * 0.009;
        }

        return 0;
    }
}