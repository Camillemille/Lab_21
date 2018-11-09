using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize a random number using random = new random int actual = test.Next(1,100)

            //Have user input a number to guess

            //Store that guess as an int

            //Print freezing if the number the user guesses is 15 or more away from the random

            //Print cold if the guess is between 6 and 15 away

            //Print warm if the guess is between 2 and 5 away

            //Print Hot if the guess is 1 away

            //Tell them they're lucky if they guess it!

            //While (userInput != actual) go back to 2

            //Add an int that counts how many guesses it takes


            Random test = new Random();
            int randomNumber = test.Next(1, 100);
            

            Console.WriteLine("Hello guess a number!");
            
            int userInput =  int.Parse(Console.ReadLine());
            int difference = randomNumber - userInput;
            int numberOfGuesses = 0;
            while (userInput != randomNumber)
            {
                numberOfGuesses++;
                if (difference > 15 || difference < -15)
                {
                    Console.WriteLine("FREEZING");
                    
                }
                else if ((difference < 15 && difference >= 6) || (difference >= 15 && difference <= -6))
                {
                    Console.WriteLine("COLD");
                   
                }

                else if ((difference <= 5 && difference >= 2 || (difference >= -5 && difference <= 2)))
                {
                    Console.WriteLine("WARM");
                   
                }
                else if (difference == 1 || difference == -1)
                {
                    Console.WriteLine("HOT");
                   

                }
                else
                {
                    Console.WriteLine("WINNER!!!");
                }

                userInput = int.Parse(Console.ReadLine());
                difference = randomNumber - userInput; // Once one of the conditions is met the user input will change too. 
                


            }

            
            Console.WriteLine($"Congradulations! it took you {numberOfGuesses} guesses");



















        }

    }
}
