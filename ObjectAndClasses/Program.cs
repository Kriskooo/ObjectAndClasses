using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            var pastDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
      
            Console.WriteLine(pastDate.DayOfWeek);
        }       
    }
}







