using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string newInput = UserInput();
            string bookInfo = UserInput("What is your favorite book");
            string favoriteColor = UserInput("What is your favorite color");
            string boolResults = UserInput(false, "Try again.");
            Console.WriteLine();

            Console.WriteLine($"{newInput}'s favorite book is {bookInfo} and favorite color is {favoriteColor}. They think \"{boolResults}!\"");


        }

        //This method does not have any perameters. 
        public static string UserInput() //Method must be in pascal case. You call it staic because the main is static
        {
            Console.WriteLine("What is your name.");
            string input = Console.ReadLine();
            return input;

        }
        // This method has perameters, string prompt. 
        public static string UserInput(string prompt)// overloading beause it is the same name as the other method.
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;

        }

        public static string UserInput(bool result, string prompt)
        {
            Console.WriteLine(prompt);
            string input;

            if (!result)
            {
                input = "it's Friday";
            }
            else
            {
                input = "it's Monday";
            }





            return input;
        }













    }



}
