using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreclasspractice
{
    public class Program 
    {



        static void Main(string[] args)
        {
            List<Contact> contactBook = new List<Contact>();
            Console.WriteLine("Welcome to contact place.");
            while (true) //keeps prompting the user
            {

                Console.WriteLine("Hello would you like to add a contact to the list.");
                Console.WriteLine("What would you like to do (add/ print/quit)");
                string input = Console.ReadLine().ToLower();
                if (input == "add")
                {
                    //add a contact to the list
                    contactBook.Add(Contact.AddContact());

                }
                else if (input == "print")
                {
                    // print all contacts to the list
                    foreach (Contact person in contactBook)
                    {
                        Console.WriteLine(person.Name);
                        Console.WriteLine(person.Address);
                        Console.WriteLine(person.PhoneNumber);
                    }
                }
                else if (input == "quit")
                {
                    //exit program
                    break;
                }
                else
                {
                    //wrong input, try again!
                    Console.WriteLine("What would you like to do (add/ print/quit)");
                    input = Console.ReadLine().ToLower();
                    
                }


            }
            Console.WriteLine("Okay bye!");

        }


















    }




}
