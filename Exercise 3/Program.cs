﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double userInput = double.Parse(Console.ReadLine());
            Console.WriteLine(userInput + .5);
        }
    }
}