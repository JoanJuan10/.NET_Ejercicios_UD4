using System;

namespace UD04_Ej11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 9;
            int num2 = 10;

            if (num1 < num2)
            {
                Console.WriteLine("El numero 2 es mas grande");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los dos numeros son iguales");
            }
            else
            {
                Console.WriteLine("El numero 1 es mas grande");
            }
        }
    }
}
