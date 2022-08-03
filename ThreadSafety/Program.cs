using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafety
{
    public class Program
    {
        static Dictionary<int, string> items = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            var task1 = Task.Factory.StartNew(AddItem);
            var task2 = Task.Factory.StartNew(AddItem);
            var task3 = Task.Factory.StartNew(AddItem);
            var task4 = Task.Factory.StartNew(AddItem);
            var task5 = Task.Factory.StartNew(AddItem);

            Task.WaitAll(task3, task2, task1, task4, task5);

            Console.ReadKey();
        }

        private static void AddItem()
        {
            //if (items.ContainsKey(1))
            //{

            //}
            //else
            //{
            //    items.Add(1, "Hello World");
            //}

            lock (items)
            {
                Console.WriteLine("Lock acquired by " + Task.CurrentId);
                items.Add(items.Count, "ABC " + items.Count);
            }

            Dictionary<int, string> dictionary;

            lock (items)
            {
                Console.WriteLine("Lock 2 acquired by " + Task.CurrentId);
                dictionary = items;
            }
            foreach (var kvp in dictionary)  //kvp --> Key-Value Pair
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}
