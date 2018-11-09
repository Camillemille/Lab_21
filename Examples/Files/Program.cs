using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    
        

class Program
        {
            static void Main(string[] args)
            {
            /*
            Console.WriteLine("Hello World!");
            //File.Copy(sourceFileName, destFileName);
            FileInfo fi = new FileInfo(@"c;\temp\MyTest.txt");
            Directory.Exists(@"c:\temp");
            DirectoryInfo di = new DirectoryInfo(@"c:temp");
            */
            Directory.CreateDirectory(@"c:\camilletemp");//Where your directory goes
                string path = @"c:\camilletemp\MyTest.txt";
                StreamWriter writer = new StreamWriter(path);  //open a stream for writing from a file
                writer.WriteLine("Word ");  //write to a stream
                writer.WriteLine("word2"); //write a line to a stream
                writer.WriteLine("another line!");
                writer.Close(); // don't want this hanging out in my memory
                                //let's read from our file!!
                StreamReader reader = new StreamReader(path);
                while (true)                 //read in a line from the file and write it out to the console
                                             //until there are no more lines
                {

                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }
                reader.Close(); 
                StreamReader reader2 = new StreamReader(path);
                string line2 = reader2.ReadLine();
                while (line2 != null)
                {
                    Console.WriteLine();
                    line2 = reader2.ReadLine();
                }
                reader2.Close();
                Console.ReadLine();
            }
        }















    }

    

