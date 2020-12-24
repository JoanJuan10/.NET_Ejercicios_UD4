using System;

namespace UD04_Ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int iva = 21;

            Console.WriteLine("Introduce el precio de un producto (puede tener decimales)");
            string precioString = Console.ReadLine();

            double precio = Convert.ToDouble(precioString);

            precio += (precio * iva) / 100;

            Console.WriteLine("El precio final es de {0} euros", precio);
        }
    }
}
