using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program

    {
        public static void Main(string[] args)
        {
           

            Console.WriteLine("Enter any number your heart desires");
            string Number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(Number1); //When a user enters in a 3 digit number it converts into an integer
            Console.WriteLine("Please enter a second number");
            string Number2 = Console.ReadLine();//A string input from the user
            int num2 = Convert.ToInt32(Number2);//When a user enters in a 3 digit number it converts into an integer

            int Digits1 = CountDigits(num1);//counting how many digits each number has
            int Digits2 = CountDigits(num2);


            if(Digits1 == Digits2)
            {
                bool answer = CheckDigits(num1, num2, Digits1);
                Console.WriteLine("The answer is magically {0}", answer);
            }

            else
            {
                Console.WriteLine("UH-OH! Something went wrong");//The numbers need to be the same number of digits
            }





        }
        public static int CountDigits(int n)
        {
            int i = 0;//counting how many digits there are
            do
            {

                n = n / 10;
                i++; //Same thing as i=i+1

            } while (n >= 1);

            return i;    

        }
        
        public static bool CheckDigits(int n, int p, int digits)
        {

            bool check = true;
            //The code is about to check if the corresponding numbers sum to the same total.
            for (int count = 1; count < digits;count++)
            {
                //each loop checks if the ones and tens place add up to the same number
                int d1 = n % 10;// when using a modulo division by 10 you are getting the ones place
                int f1 = p % 10;
                int n2 = n / 10; //When dividing n/10 you get the number without the ones place
                int p2 = p / 10;
                int d2 = n2 % 10;
                int f2 = p2 % 10;
                bool eq = ((d1 + f1) == (d2 + f2)); //If d1+f1 is equal to d2+f2 then the statement is true if not it will be false
                check = check & eq;
                n = n2;//checks the next two digits in the next loop run
                p = p2;

            }
             
             




            return check;
        }

    }
}
