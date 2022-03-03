using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    internal class Timer
    {
        public delegate void TimeChange(int sec);
        public event TimeChange TimeChangeEvent;
        public event TimeChange TimeChangeEventM;
        public event TimeChange TimeChangeEventH;



        private int _seconds;
        private int _minutes;
        
        private int _hours;

        public Timer(int seconds, int minutes, int hours)
        {
            _seconds = seconds;
            _minutes = minutes;
            _hours = hours;
        }

        public int Seconds { get => _seconds; set => _seconds = value; }
        public int Minutes { get => _minutes; set => _minutes = value; }
        public int Hours { get => _hours; set => _hours = value; }

        public void Start()
        {
            for(int i=0;i<1001;i++)
            {
                
                if (i== 1000)
                {
                    Thread.Sleep(1000);
                    SecAdd(1);
                    i -= 1000;
                }
            }
        }

        public void SecAdd(int sec)
        {
            _seconds += sec;
            TimeChangeEvent?.Invoke(sec);
            Console.WriteLine($"время: ч:{_hours} м:{_minutes} с:{_seconds}");
            SecMinNHour(0);

        }
        public void SecMinNHour(int sec)
        {
            if (_hours==23 &&_minutes == 59 && _seconds == 59)
            {
                TimeChangeEventH?.Invoke(sec);
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
                Console.WriteLine($"время: ч:{_hours} м:{_minutes} с:{_seconds}");

            }

            if (_minutes == 59 && _seconds == 59)
            {
                _hours += 1;
                TimeChangeEventH?.Invoke(sec);
                Minutes = 0;
                Seconds = 0;
                Console.WriteLine($"время: ч:{_hours} м:{_minutes} с:{_seconds}");

            }

            if (_seconds==59)
            {
                _minutes += 1;
                TimeChangeEventM?.Invoke(sec); 
                Seconds = 0;
                Console.WriteLine($"время: ч:{_hours} м:{_minutes} с:{_seconds}");

            }


            

        }

    }
}
