using System;

namespace UD04_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu ciudad:");
            string ciudad = Console.ReadLine();

            // He decidido por este método de mostrar variables ya que me parece más cómodo.
            Console.WriteLine("Hola {0} bienvenido a {1}", nombre, ciudad);

        }
    }
}
