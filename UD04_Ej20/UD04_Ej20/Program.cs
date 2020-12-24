using System;

namespace UD04_Ej20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedimos el numero de ventas
            Console.WriteLine("Introduce el numero de ventas que has obtenido");
            string numVentasString = Console.ReadLine();

            int numVentas = Convert.ToInt32(numVentasString);
            int[] ventas = new int[numVentas];

            // Por cada venta, pedimos lo recaudado y lo guardamos
            for (int i = 0; i < numVentas; i++)
            {
                Console.WriteLine("Introduce la venta {0}", (i + 1));
                string ventaString = Console.ReadLine();

                ventas[i] = Convert.ToInt32(ventaString);

            }
            int sumVentas = 0;
            // Por cada venta, lo sumamos al total.
            for (int i = 0; i < numVentas; i++)
            {
                sumVentas += ventas[i];
            }
            Console.WriteLine("Total en ventas: {0} euros", sumVentas);
        }
    }
}
