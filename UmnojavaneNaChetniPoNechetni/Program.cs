using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmnojavaneNaChetniPoNechetni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи цяло число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(MultipleOfEvAndOdds(number));
            Console.WriteLine("------------------------------------");
        }
        private static int MultipleOfEvAndOdds(int number)
        {
            int sumevens = SumOfEvDig(Math.Abs(number));
            int sumodds = SumOfOddDig(Math.Abs(number));

            return sumevens * sumodds;
        }
        private static int SumOfOddDig(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    result = result + lastDigit;
                }
                number /= 10;
            }
            return result;
        }
        private static int SumOfEvDig(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    result += lastDigit;
                }
                number /= 10;
            }
            return result;
        }
    }
}

