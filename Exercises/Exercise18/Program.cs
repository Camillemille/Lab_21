using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userInput = int.Parse(Console.ReadLine());
            int sum = userInput;
            for (int i = 1; i < userInput; i++)
            {
                sum = sum + i;
                
                
                    
            }


            Console.WriteLine(sum);


        }



    }
}
