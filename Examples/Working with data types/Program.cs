using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //signed integral types. These are integer values, both positive and negative
            //sbyte
            sbyte mySbyte = 27;
            Console.WriteLine("sbyte: " + mySbyte);

            //short example
            short myShort = 1188;
            Console.WriteLine("short: " + myShort);

            //int example
            int myInt = 5467381;
            Console.WriteLine("int: " +myInt);

            //long example
            long myLong = 709181846L;
            //L represents that this is a Long datatype. Use capital L
            Console.WriteLine("Long:" + myLong);

            //floating point data types. They contain values with a decimal point
            //these have a lot of precision

            //float example use when you don't really need that much number percision.
            float myFloat = 45.27F;
            //F represents that it's a float
            Console.WriteLine("float: " + myFloat);

            //double example used most of the time.
            double myDouble = -13854.98765D;
            //D represents double 
            //all real numbers in C# are defaulted to type double unless specified
            //so don't really need the D
            Console.WriteLine("double: " + myDouble);

            //decimal example. When you use things todo with money/buisness app.
            decimal myDecimal = 54335.84M;
            //use M to represent decimal data type
            Console.WriteLine("decimal: " + myDecimal);

            //I want a blank line
            Console.WriteLine();

            //let's do an example to show the difference between float 
            //and double and decimal. I'll line them up so you can see
            float floatPI = 3.14159265358979323846F;
            double doublePI = 3.14159265358979323846D;
            decimal decimalPI = 3.14159265358979323846M;
            Console.WriteLine("float: " + floatPI);
            Console.WriteLine("double: " + doublePI );
            Console.WriteLine("decimal: " + decimalPI);

            Console.WriteLine(); //I want another blank line

            //char example
            char myChar = 'a';
            Console.WriteLine("char: " + myChar);

            //value type vs reference type
            //value type: strored on the stack. Stores the actual value 
            //refernce types: Stored on the heap. Points to where things are stored. strings, arrays.








        }
    }
}
