using System;

namespace ThayHuy
{
    public class Program
    {
		static void Main()

		{ Console.WriteLine("    Loading");
			ConsoleUtility.WriteProgressBar(0);
			for (var i = 0; i <= 100; ++i)
			{
				ConsoleUtility.WriteProgressBar(i,true);
				System.Threading.Thread.Sleep(50);
			}
			Console.WriteLine();
			ConsoleUtility.WriteProgress(0);
			for (var i = 0; i <= 100; ++i)
			{
				ConsoleUtility.WriteProgress(i, true);
				System.Threading.Thread.Sleep(50);
			}
            Console.WriteLine("Hello, Mr.Huy!");
		}
	}
}
