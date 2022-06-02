using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient; 
            int remainder;

            var sum = a + b;
            Console.WriteLine($"a + b = {sum}");

            Console.WriteLine($"a - b = {a - b}");

            var product = a * b;
            Console.WriteLine($"a x b = {product}");

            quotient = a / b;

            remainder = a % b;

            Console.WriteLine($"a / b = {quotient} with a remainder of {remainder}");

            Console.WriteLine();

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with a {radius} is {area}");

        }

    }
}
