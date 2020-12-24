using System;

namespace UD04_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool precioCorrecto = false;
            Console.WriteLine("Escribe un precio de producto");
            string precioString = Console.ReadLine();
            
            // Pruebo si el precio es positivo
            try
            {
                uint precio = Convert.ToUInt32(precioString);
                precioCorrecto = true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Precio negativo!");
            }

            // Si el precio es correcto continuo
            if (precioCorrecto)
            {
                Console.WriteLine("Elige tu forma de pago:");
                Console.WriteLine("1 = Tarjeta");
                Console.WriteLine("2 = Efectivo");
                string eleccion = Console.ReadLine();
                // Si me elige tarjeta le pido el numero de cuenta.
                if (eleccion == "1")
                {
                    Console.WriteLine("Introduce tu numero de cuenta");
                    string numCuenta = Console.ReadLine();
                }
                else if (eleccion != "2")
                {
                    Console.WriteLine("Eleccion incorrecta");
                }
            }
            
        }
    }
}
