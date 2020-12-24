using System;

namespace UD04_Ej22
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "1234";
            bool acertada = false;
            int intentos = 3;

            while (!acertada && intentos > 0)
            {
                Console.WriteLine("Introduce la contraseña ({0} intentos)", intentos);

                string contra = Console.ReadLine();

                if (contra == password)
                {
                    Console.WriteLine("Enhorabuena!!");
                    acertada = true;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    intentos--;
                }
            }
            
        }
    }
}
