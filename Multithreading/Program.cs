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

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method1 is : {0}", i);

                if (i == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }
        public static void Method2()
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Method2 is : {0}", j);
            }
        }

        public static void Main()
        {
            Thread thr1 = new Thread(Method1);
            Thread thr2 = new Thread(Method2);
            thr1.Start();
            thr2.Start();
            Console.ReadKey();
        }
    }
}
