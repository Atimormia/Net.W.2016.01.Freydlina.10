using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomTimer timer = new CustomTimer();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            timer.OnTimeIsOver += handler1.Ring;
            timer.OnTimeIsOver += handler2.Ring;

            timer.StartTimer(new TimeSpan(0,0,5));
            Console.ReadKey();
        }
    }
}
