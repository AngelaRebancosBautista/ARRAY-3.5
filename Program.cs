using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integers");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input.");
                    Console.Write($"Number {i + 1}: ");
                }
            }
            int evenCount = 0;
            int oddCount = 0;
            int divisibleByFiveCount = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                if (number % 5 == 0)
                {
                    divisibleByFiveCount++;
                }
            }
            Console.WriteLine($"\nCount of even numbers: {evenCount}");
            Console.WriteLine($"Count of odd numbers: {oddCount}");
            Console.WriteLine($"Count of numbers divisible by 5: {divisibleByFiveCount}");
        }
    }
}


