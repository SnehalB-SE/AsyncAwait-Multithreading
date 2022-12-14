using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoEvent
{
    internal class Program
    {
        //static EventWaitHandle autoResetEvent = new EventWaitHandle(false, EventResetMode.AutoReset); //Manual reseting

        static AutoResetEvent eventWaitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Task.Factory.StartNew(WorkerThread);
            Thread.Sleep(2500);
            eventWaitHandle.Set();
        }

        private static void WorkerThread()
        {
            Console.WriteLine("Waiting to enter the gate");
            eventWaitHandle.WaitOne();
            Console.WriteLine("Gate Entered");
        }
    }
}
