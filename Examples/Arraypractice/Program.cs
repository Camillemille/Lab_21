using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraypractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //use copyTo with arrays when you want to copy it. 


            string[] fruits = new string[5];
            fruits[0] = "Apples";
            fruits[1] = "Grapes";
            fruits[2] = "Pinapple";
            fruits[3] = "Strawberries";
            fruits[4] = "Watermelon";

            foreach (string fruit in fruits) //singular fruit is what we call the items in the array
            {
                Console.WriteLine(fruit);
    
            }

            // 2d array [,]
           // jagged arrays [] []
            









        }
    }
}
