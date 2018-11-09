using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the {0} elements of the array", n);
            int[] num = new int[n];
            
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter the value number {0}", i++);
                num[i] = Convert.ToInt32(Console.ReadLine());
                
            }


            Console.Write("The sum of numbers stored in the array is: {0}");
            Console.ReadLine();
             
            










        }
    }
}
