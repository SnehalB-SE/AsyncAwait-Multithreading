using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class Program
    {
        public static void Method1()
        {

            // It prints numbers from 0 to 10
            for (int I = 0; I <= 10; I++)
            {
                Console.WriteLine("Method1 is : {0}", I);

                // When the value of I is equal to 5 then
                // this method sleeps for 6 seconds
                if (I == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }

        // static method two
        public static void Method2()
        {
            // It prints numbers from 0 to 10
            for (int J = 0; J <= 10; J++)
            {
                Console.WriteLine("Method2 is : {0}", J);
            }
        }

        // Main Method
        public static void Main()
        {
            // Creating and initializing threads
            Thread thr1 = new Thread(Method1);
            Thread thr2 = new Thread(Method2);
            thr1.Start();
            thr2.Start();
            Console.ReadKey();
        }
    }
}
