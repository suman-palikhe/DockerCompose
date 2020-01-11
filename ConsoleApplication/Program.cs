using System;
using System.Threading;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(10000);
                Console.WriteLine("Hello World! Second time");
               
            }
            
        }
    }
}
