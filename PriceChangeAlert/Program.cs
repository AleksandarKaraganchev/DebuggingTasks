using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChangeAlert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Price number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Threshold of significance: ");
            double significanceThreshold = double.Parse(Console.ReadLine());
            Console.Write("Previous price: ");
            double previousprice = double.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                Console.Write("Price now: ");
                double currentprice = double.Parse(Console.ReadLine());
                double differencepercentage = DifferencePercentage(previousprice, currentprice);
                bool isSignificant = Math.Abs(differencepercentage) > significanceThreshold;
                string message = Message(currentprice, previousprice, differencepercentage, isSignificant);
                Console.WriteLine(message);
                previousprice = currentprice;
            }
        }
        static double DifferencePercentage(double previousPrice, double currentPrice)
        {
            return (currentPrice - previousPrice) / previousPrice * 100;
        }
        static string Message(double currentPrice, double previousprice, double differencepercentage, bool isSignificant)
        {
            if (differencepercentage == 0)
            {
                return string.Format($"NO CHANGE: {currentPrice}");
            }
            else if (!isSignificant)
            {
                return string.Format($"MINOR CHANGE: {previousprice} to {currentPrice} {differencepercentage:F2}%");
            }
            else if (differencepercentage > 0)
            {
                return string.Format($"PRICE UP: {previousprice} to {currentPrice} {differencepercentage:F2}%");
            }
            else
            {
                return string.Format($"PRICE DOWN: {previousprice} to {currentPrice} {differencepercentage:F2}%");
            }
        }
    }
}

