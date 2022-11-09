using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool oddReasult1 = 100.isOdd();
			Console.WriteLine(oddReasult1);
			bool oddReasult2 = 99.isOdd();
			Console.WriteLine(oddReasult2);
			bool evenReasult1 = 100.isEven();
			Console.WriteLine(evenReasult1);
			bool evenReasult2 = 99.isEven();
			Console.WriteLine(evenReasult2);
		}

		

	}

	public static class TestMath
	{
		public static bool isOdd(this int num)
		{
			return num %2 == 1;
		}
		public static bool isEven(this int num)
		{
			return num % 2 == 0;
		}
	}
}
