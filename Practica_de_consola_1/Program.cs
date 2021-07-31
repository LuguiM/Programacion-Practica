using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables y inicialize en cero.
            int num1 = 0; int num2 = 0;

            // Mostrar titulo que es calculadora de consola de C#
            Console.WriteLine("Calculadora de consola en C#\r");
            Console.WriteLine("------------------------\n");

            // Pedirle el primer numero al usuario.
            Console.WriteLine("Escribe un numero, y preciona Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Pedirle el segundo numero al usuario
            Console.WriteLine("Escribe otro numero, y preciona Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Preguntarle al usuario la opcion a elegir.
            Console.WriteLine("Escogser una opcion del siguiente listado:");
            Console.WriteLine("\ts - Suma");
            Console.WriteLine("\tr - Resta");
            Console.WriteLine("\tm - Multiplicacion");
            Console.WriteLine("\td - Divicion");
            Console.Write("Cual es tu opcion? ");

            // Use switch para que realice la operacion matematica
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Tu resultado es: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"Tu resultado es: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado es: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado es: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espere que el usuario responda para despues cerrar.
            Console.Write("Presiona cualquier tecla para cerrar la calculadora de consola...");
            Console.ReadKey();
        }
    }
}