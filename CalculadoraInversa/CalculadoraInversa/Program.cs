using System;


namespace CalculadoraInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer operando");
            string operando1String = Console.ReadLine();
            int operando1 = Convert.ToInt32(operando1String);

            Console.WriteLine("Introduce el segundo operando");
            string operando2String = Console.ReadLine();
            int operando2 = Convert.ToInt32(operando2String);

            Console.WriteLine("Introduce el signo aritmetico");
            string signo = Console.ReadLine();

            double resultado = 0;
            
            switch (signo)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    resultado = operando1 / operando2;
                    break;
                case "^":
                    resultado = Math.Pow(operando1, operando2);
                    break;
                case "%":
                    resultado = operando1 % operando2;
                    break;
            }
            Console.WriteLine("Resultado de la operación: {0}", resultado);
        }
    }
}
