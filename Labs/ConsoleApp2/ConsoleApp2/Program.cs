using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day: ");//This is what the user sees
            string inputdate1 = Console.ReadLine();
            int date1 = Convert.ToInt32(inputdate1); //Convert the string into a int
            Console.WriteLine("Month: ");
            String inputmonth1 = Console.ReadLine();
            int month1 = Convert.ToInt32(inputmonth1);
            Console.WriteLine("Year : ");
            string inputyear1 = Console.ReadLine();
            int year1 = Convert.ToInt32(inputyear1);

            Console.WriteLine("Day 2: ");
            string inputdate2 = Console.ReadLine();
            int date2 = Convert.ToInt32(inputdate2);
            Console.WriteLine("Month 2: ");
            string inputmonth2 = Console.ReadLine();
            int month2 = Convert.ToInt32(inputmonth2);
            Console.WriteLine("Year 2: ");
            string inputyear2 = Console.ReadLine();
            int year2 = Convert.ToInt32(inputyear2);

            DateTime dayone = new DateTime(year1, month1, date1); //creating a new datetime using the year, month and day from the user
            DateTime daytwo = new DateTime(year2, month2, date2);

            TimeSpan datesinput = dayone.Subtract(daytwo);//Using the subtract operator of datetime to find the differance of days


            Console.WriteLine("The interval is {0}", datesinput);


        }
    }
}
