using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_about_testing
{
    class Program
    {


    }
        public class LeapYear

    {
        public static bool IsLeapYear(int year)
        {
            if(year % 4 != 0)
            {
                return false;
            }
            else if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            return true;
            
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int userYear = int.Parse(Console.ReadLine());
            bool isLeapYear = LeapYear.IsLeapYear(userYear);
            if (isLeapYear)
            {
                Console.WriteLine(userYear + " is a leap year");

            }
            else
            {
                Console.WriteLine(userYear + " is not a leap year");
            }


        }








    }
      
     public class DoSomeMath
    {
        public static int Add(int a, int b)
        {
            return a + b; 
                
        }
    }
    
}
