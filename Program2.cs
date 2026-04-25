using System;

internal class Program
{
    static void CalcularCompras(double[,] clientes)
    {
        for (int i = 0; i < 5; i++)
        {
            double total = 0;

            for (int j = 0; j < 5; j++)
            {
                total = total + clientes[i, j];
            }

            double descuento = 0;

            if (total >= 100 && total <= 1000)
            {
                descuento = total * 0.10;
            }
            else if (total > 1000)
            {
                descuento = total * 0.20;
            }

            Console.WriteLine("Cliente " + (i + 1) + ":");
            Console.WriteLine("Total de compras: " + total);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + (total - descuento));
            Console.WriteLine("-------------------");
        }
    }

    static void Main(string[] args)
    {
        double[,] clientes = new double[,]
        {
            { 50, 30, 20, 10, 5 },
            { 200, 150, 300, 100, 250 },
            { 500, 600, 400, 300, 350 },
            { 80, 60, 70, 50, 40 },
            { 1200, 800, 600, 400, 500 }
        };

        CalcularCompras(clientes);
    }
}