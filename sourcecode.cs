using System;

namespace Input
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter a number 1-10");
			string answer = Console.ReadLine();

			if (Convert.ToInt64(answer) <= 10) Console.WriteLine("valid");

			else Console.WriteLine("invalid");

		}
	}
}
