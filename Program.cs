using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a natural number: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                Console.Write("Digits in reverse order: ");
                Console.WriteLine(ReverseDigits(number));
            }
            else
            {
                Console.WriteLine("Please enter a valid natural number.");
            }
        }

        static string ReverseDigits(int number)
        {
            string result = (number % 10).ToString();

            if (number / 10 > 0)
            {
                result += ReverseDigits(number / 10);
            }

            return result;
        }
    }
}
