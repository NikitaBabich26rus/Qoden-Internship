using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var calculator = new Calculator();
            Console.WriteLine(calculator.Calculate(expression));
        }
    }
}
