using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class CustomTimer
    {
        public delegate void Ring();

        public event Ring OnTimeIsOver;

        public void StartTimer(TimeSpan time)
        {
            Thread.Sleep(time);
            OnTimeIsOver?.Invoke();
        }

    }
}
