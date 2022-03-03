using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(0,0,0);
            Clock clock = new Clock();

            timer.TimeChangeEventH += clock.ParseTime3;
            timer.TimeChangeEventM += clock.ParseTime2;
            timer.TimeChangeEvent += clock.ParseTime;
            timer.Start();
            
            Console.ReadLine();
        }

        
    }
}
