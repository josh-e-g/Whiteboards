using System;

namespace PrimeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("PrimeNumbers.Program.Main()");
			Console.WriteLine(IsPrime(223051));
		}
		public static bool IsPrime(int number)
		{
			if (number <= 1) return false;
			for (int i = number - 1; i != 1; i--)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
