using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Program
    {
		static readonly Stopwatch timer = new Stopwatch();
		public static async Task Main()
		{
			Program obj = new Program();
			await obj.ProcessAsync();
			Console.ReadKey();
		}
		public async Task ProcessAsync()
		{
			timer.Start();
			var data = await GetDataFromDBAsync();
			Console.WriteLine("In the Main Method " + data + " " + timer.ElapsedMilliseconds.ToString());
			var processedData = await ProcessDataAsync(data);
			await WriteToDBAsync(processedData);
		}
		public static async Task<int> GetDataFromDBAsync()
        {
			Console.WriteLine("GetDataFromDBAsync Started..." + timer.ElapsedMilliseconds.ToString());
			//Thread.Sleep(5000);
			await Task.Delay(5000);
			//var ProcessResult = await ProcessDataAsync(100);
			//Console.WriteLine("Result from ProcessDataAsync: " + ProcessResult + " " + timer.ElapsedMilliseconds.ToString());
			var a = 0;
            for (int i = 0; i < 500_000_000; i++)
            {
				a += i;
            }
			Console.WriteLine("GetDataFromDBAsync Result a = " + a + " " + timer.ElapsedMilliseconds.ToString());
			return a;
        }
		public static async Task<int> ProcessDataAsync(int data)
		{
			Console.WriteLine("ProcessDataAsync:: Processing Data : " + data + " " + timer.ElapsedMilliseconds.ToString());
			await Task.Delay(1000);
			Console.WriteLine("ProcessDataAsync:: Processing End : " + data + " " + timer.ElapsedMilliseconds.ToString());
			return 0;
		}
		public static async Task<int> WriteToDBAsync(int processedData)
		{
			Console.WriteLine("Data");
			await Task.Delay(1000);
			return 1;
		}

	}
}
