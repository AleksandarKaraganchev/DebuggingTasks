using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PochivniDniMejduDveDati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи дата за начало (начална дата): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Въведи дата за край на почивката (крайна дата): ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            byte counter = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    counter++;
                }
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(counter);
            Console.WriteLine("--------------------------------------------");
        }
    }
}
