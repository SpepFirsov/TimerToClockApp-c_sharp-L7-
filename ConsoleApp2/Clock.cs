using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Clock { 
        public void ParseTime(int sec)
        {   
            Console.WriteLine($"[!] прошла секунда");
        }

        public void ParseTime2(int sec)
        {
            Console.WriteLine($"[!] прошла минута");
        }

        public void ParseTime3(int sec)
        {
            Console.WriteLine($"[!] прошёл час");
        }

    }
}
