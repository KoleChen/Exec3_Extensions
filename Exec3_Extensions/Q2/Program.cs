using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入文字或數字:");
			string input = Console.ReadLine();
			string result = input.Left(3);
			Console.Write("您剛剛輸入的前三個字是:");
			Console.WriteLine(result);
		}
	}

	public static class Teststring
	{
		public static string Left(this string st,int length)
		{
			if (string.IsNullOrEmpty(st)) return string.Empty;
			if (length <= 0) return string.Empty;
			if(st.Length <= length) return st;

			return st.Substring(0, length);
		}
	}
}
