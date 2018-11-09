using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine(i * i);
            }   
        }
    }
}
