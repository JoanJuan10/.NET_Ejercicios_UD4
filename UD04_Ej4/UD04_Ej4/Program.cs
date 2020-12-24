using System;

namespace UD04_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedimos los numeros y los convertimos
            Console.WriteLine("Escribe un numero:");
            string numero1 = Console.ReadLine();

            int num1 = Convert.ToInt32(numero1);


            Console.WriteLine("Escribe otro numero:");
            string numero2 = Console.ReadLine();

            int num2 = Convert.ToInt32(numero2);

            // Comprobamos cual es mayor

            if (num1 < num2)
            {
                Console.WriteLine("El numero 2 ({0}) es mayor.", num2);
            }
            else
            {
                Console.WriteLine("El numero 1 ({0}) es mayor.", num1);
            }
        }
    }
}
