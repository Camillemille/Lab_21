using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1assesment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose either Kia or Volkswagen." );
            string input = Console.ReadLine().ToLower();

            string[] carsToPick = new string[2];
            carsToPick[0] = "Volkswagen";
            carsToPick[1] = "Kia";
            
            foreach (string cars in carsToPick)
            {
                if (input == "Volkswagen")
                {
                    
                    Console.WriteLine("You have choosen Volkswagen");
                }
                else if(input == "Kia")
                {
                    Console.WriteLine("You have choosen Kia");
                }
            }







        }


    }
}
