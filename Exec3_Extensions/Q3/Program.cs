using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{		
			Console.WriteLine("請輸入數字,若不是數字則會顯示0");
			string value = Console.ReadLine();
			Console.WriteLine("轉換結果為");
			Console.WriteLine(value.ToInt(0));
		}
	}

	public static class ConvertExtension
	{
		public static int ToInt(this string value,int defaultValue)
		{
			bool isInt = int.TryParse(value , out int result);
			return isInt ? result : defaultValue;
		}
	}
}
