using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise38
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] numStored = new int[5]; //5 is the size of the array.
            //Accepting value from the user
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your number:");
                //storing value in an array
                numStored[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            
            //Printing value to the console
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("You entered {0}", numStored[i]);
                    
                
            }
            int sum = numStored[0] + numStored[1];
            Console.WriteLine(sum);

            Console.ReadLine();












        }
    }
}
