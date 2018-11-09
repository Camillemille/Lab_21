using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_practice
{

        class Program
        {
            public enum daysOfTheWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
            static void Main(string[] args)
            {
                //prompt the user for a day of the week
                Console.WriteLine("Please enter a day of the week (i.e. Tuesday, Friday");
                //parse the day of the week into an enum
                string userInput = Console.ReadLine();
                daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), userInput);

                //print out a message based ont he day of the week
                switch (day)
                {
                    case daysOfTheWeek.Sunday:
                    {
                        Console.WriteLine("#beatyourmeat Sunday!");
                        break;
                    }
                    case daysOfTheWeek.Monday:
                    {
                        Console.WriteLine("We actually like Mondays");
                        break;
                    }
                    case daysOfTheWeek.Tuesday:
                    {
                        Console.WriteLine("Clubs goin' up on a Tuesday!");
                        break;
                    }
                    case daysOfTheWeek.Wednesday:
                    {
                        Console.WriteLine("Whiskey Wednesday");
                        break;
                    }
                    case daysOfTheWeek.Thursday:
                    {
                        Console.WriteLine("Thristy Thursday");
                        break;
                    }
                    case daysOfTheWeek.Friday:
                    {
                        Console.WriteLine("Freak out for Fridays");
                        break;
                    }
                    case daysOfTheWeek.Saturday:
                    {
                        Console.WriteLine("Sidetrack Saturdays");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Not sure how you got here.");
                        break;
                    }
                }
            }
        }
    
}
