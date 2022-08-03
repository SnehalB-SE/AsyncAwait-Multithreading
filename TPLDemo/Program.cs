using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Time taken by For Loop: " + stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();
            stopwatch.Start();
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i);
            });
            Console.WriteLine("Time taken by Parallel For Loop: " + stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
