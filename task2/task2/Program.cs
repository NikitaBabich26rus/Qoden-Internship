using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var wordStatistics = new WordStatistics();
            var result = wordStatistics.GetStatistics(text);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
