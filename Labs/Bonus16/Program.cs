using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void BuildCarList()
            {
                List<Car> myCarList = new List<Car>();
                int userInput = GetNumberOfCars();


                for (int i = 1; i <= userInput; i++)
                {
                    Console.WriteLine("What is the " + i + " make? ");
                    string make = Console.ReadLine();
                    Console.WriteLine("What is the model?");
                    string model = Console.ReadLine();
                    Console.WriteLine("What is the year?");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the price?");
                    double price = double.Parse(Console.ReadLine());

                    Car myCar = new Car();
                    myCar.Make = make;
                    myCar.Model = model;
                    myCar.Year = year;
                    myCar.Price = price;

                    myCarList.Add(myCar);

                }

                foreach (Car item in myCarList)
                {
                    Console.WriteLine(item.ToString());
                }


            }

            public int GetNumberOfCars()
            {
                Console.WriteLine("Please enter number of cars you want:");
                int userInput = int.Parse(Console.ReadLine());
                return userInput;
            }

        }
    }
}

    

    

