using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collections aka Generics aka Lists
            //generics create typed collection which can hold objects of any type. <>
            //include System.Collections.Generic when using



            bool userContinue = true; //deciding if the user wants to continue
            List<string> colorList = new List<string>();

            while (userContinue)
            {
                Console.WriteLine("Hello I am the color monster. FEED ME!");
                Console.WriteLine("Give me a F-ing color");
                colorList.Add(Console.ReadLine());
                Console.WriteLine("Do you want to add anothor color you fool? (y/n)");
                string result = Console.ReadLine().ToLower();
                while (result != "y" && result != "n")
                {
                    Console.WriteLine("ENTER the GOD DANG CORRECT THING YA NOOB! ");
                    Console.WriteLine("HEY! WOULD YOU LIKE TO ADD ANOTHOR COLOR TO THE LIST OR ARE YOU STUPID?");
                    Console.ReadLine().ToLower();
                }
                if (result == "y")
                {
                    userContinue = true;
                }
                else
                {
                    userContinue = false;
                }






            }

          for(int i =0; i < colorList.Count; i++)
            {
                Console.Write($"{colorList[i]}, ");
            }


            


























        }
    }
}
