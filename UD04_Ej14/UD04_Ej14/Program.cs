using System;

namespace UD04_Ej14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio del circulo (No uses . para el decimal. Usa ,)");
            string radioString = Console.ReadLine();

            double radio = Convert.ToDouble(radioString);

            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("Area: {0}", area);

        }
    }
}
