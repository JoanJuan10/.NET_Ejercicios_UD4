using System;

namespace UD04_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu edad:");
            string edad = Console.ReadLine();

            Console.WriteLine("Te llamas {0} y tienes {1} años", nombre, edad);
        }
    }
}
