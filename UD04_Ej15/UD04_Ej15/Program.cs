using System;

namespace UD04_Ej15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero");
            string numString = Console.ReadLine();

            int num = Convert.ToInt32(numString);

            if (num % 2 == 0)
            {
                Console.WriteLine("Divisible entre 2");
            }
            else
            {
                Console.WriteLine("No divisible entre 2");
            }
        }
    }
}
