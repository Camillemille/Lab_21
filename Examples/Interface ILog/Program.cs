using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp12
{
    interface ILog
    {
        void Log(string msgToLog);
    }
    class FileLog : ILog
    {
        public FileLog(string fileName)
        {
            //get a file name
        }
        private string myFileName; //file i will use for my log
        public string MyFileName //properties to access myFileName
        {
            get
            {
                return MyFileName;
            }
            set
            {
                MyFileName = value;
            }
        }
        public void Log(string msgToPrint)
        {
            //Open the log lfile as a streamwriter, append message o log, close the streamwriter
            StreamWriter logFile = new StreamWriter(@"c:\temp]log.txt", true);
            logFile.WriteLine(msgToPrint);
            logFile.Close();
        }
    }
    class ConsoleLog : ILog
    {
        public ConsoleLog()
        {
            Console.WriteLine("in my constructor");
        }
        //have to has void Log(string) because its in my interface
        public void Log(string msgToPrint)
        {
            Console.WriteLine(msgToPrint);
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            //make an instance of ConsoleLog
            ConsoleLog conLog = new ConsoleLog();
            //call my log method in my class
            conLog.Log("log this message!!");

            //make an instance of FileLog
            FileLog fileLog = new FileLog(@"c:\temp/myFileForLogging.txt");
            //call log method in the FileLog Class
            fileLog.Log("log this message!!!");
        }
    }
}























































}  