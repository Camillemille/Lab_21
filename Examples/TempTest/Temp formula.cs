using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    public class ConvertTemp
    {
        public static int TempConvert(int temp, string unit)
        {
            while (true)
            {
                if (unit == "c")
                {
                    return (temp * 9 / 5) + 32;
                }
                else if (unit == "f")
                {
                    return (temp - 32) * (5 / 9);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}