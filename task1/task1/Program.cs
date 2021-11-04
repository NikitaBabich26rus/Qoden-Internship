using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {

        static void PrintList(ListNode node)
        {
            var currentNode = node;
            while (currentNode != null)
            {
                Console.Write($" {currentNode.Value}");
                currentNode = currentNode.Next;
            }
        }

        static void PrintResult(IEnumerable<ListNode> hashTable)
        {
            var counter = 0;
            foreach (var item in hashTable)
            {
                Console.Write($"{counter}:");
                if (item != null)
                {
                    PrintList(item);
                }
                Console.WriteLine();
                counter++;
            }
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var values = Console.ReadLine();
            var valuesArray = values.Split(' ');

            var hashTable = new HashTable(n);
            foreach (var item in valuesArray)
            {
                var value = Convert.ToInt64(item);
                hashTable.Insert(value);
            }

            var result = hashTable.Values;
            PrintResult(result);
        }
    }
}
