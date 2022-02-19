using System;

namespace Operaciones
{
    class Program
    {

        static void Main(string[] args)
        {
            Int32 num1;
            Int32 num2;
            Console.WriteLine("Introduce tu primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            num2 = int.Parse(Console.ReadLine());

            
            Int32 suma = num1 + num2;
            Int32 resta = num1 - num2;
            Int32 mult = num1 * num2;

            Console.WriteLine("La suma de ambos números es: " + suma);
            Console.WriteLine("La resta de ambos números es: " + resta);
            Console.WriteLine("La multiplicación de ambos números es: " + mult);

        }

    }
}