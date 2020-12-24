using System;

namespace UD04_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diasSemana = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};
            bool encontrado = false;

            Console.WriteLine("Escribe un nombre de semana");
            string dia = Console.ReadLine();

            for (int i = 0; i < diasSemana.Length; i++)
            { 
                if (dia == diasSemana[i])
                {
                    encontrado = true;
                    if (dia == "Sabado" || dia == "Domingo")
                    {
                        Console.WriteLine("Es fin de semana");
                    }
                    else
                    {
                        Console.WriteLine("No es fin de semana");
                    }
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Dia de la semana incorrecto");
            }
        }
    }
}
