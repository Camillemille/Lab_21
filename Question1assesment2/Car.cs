using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1assesment2
{
    public class Car
    {
        private string vin;
        private string make;
        public string Vin
        {
            get
            {
                return vin;
            }

            set
            {
                vin = value;
            }


        }
        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value; 
            }



        }

        public Car()
        {
            vin = "xxxxxxxx";
            make = "Volkswagen"; 
        }

        public override string ToString()
        {
            return $"The vin is {vin} and the make is {make}";
        }

        public static Car AddCar()
        {
            Console.WriteLine("Please a vin");
            string userVin = Console.ReadLine();
            Console.WriteLine("The model is");
            string userMake = Console.ReadLine();
            return new Car (); 
            
        }












    }






}
