using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                sum = sum + i; 
            }


            Console.WriteLine($" The sum of all the numbers from {num1} to {num2} is {sum}");


        }




        
    }
}
