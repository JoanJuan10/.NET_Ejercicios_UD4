using System;

namespace UD04_Ej21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un dia de la semana");
            string diaSemana = Console.ReadLine();
            diaSemana = diaSemana.ToLower();

            switch (diaSemana)
            {
                case "lunes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "martes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("Dia laboral");
                    break;
                case "jueves":
                    Console.WriteLine("Dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "sabado":
                    Console.WriteLine("Dia festivo");
                    break;
                case "domingo":
                    Console.WriteLine("Dia festivo");
                    break;
                default:
                    Console.WriteLine("Dia no valido");
                    break;
            }
        }
    }
}
