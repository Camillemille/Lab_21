using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Print all numbers from 1 to 100
            // 2. Add a condition so that numbers divisible by 3 print out as FIZZ
            // 3. Add another condition for numbers divisible by 5 to print as BUZZ
            // 4. Add ANOTHER condition for numbers divisible by both to print as FIZZBUZZ


            //print all numbers 1-100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 3 == 0)
                {
                    if (i % 5 == 0) // This line is for numbers divisible by both 3 and 5 like 15
                    {
                        Console.WriteLine("FIZZ BUZZ");
                    }
                    else

                        Console.WriteLine("FIZZ"); // If they are only divisible by 3 this if will break out of the loop and read this line.  
                    }
                
                else if (i % 5 == 0) // Numbers divisible by 5 will print BUZZ. 
                {
                    Console.Write("Console BUZZ");
                }

                else if ((i % 3 == 0) && (i % 5 == 0)) // Numbers divisible by both will FIZZBUZZ.
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }




















            }
        }



    }
}
