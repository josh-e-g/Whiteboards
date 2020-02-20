using System;

namespace SumOfPrimes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("SumOfPrimes.Program.Main()");
			Console.WriteLine(SumOfPrimes(100));
		}
		public static int SumOfPrimes(int number)
		{
			int count = 0;
			int sum = 0;
			for (int i = 2; count != number; i++)
			{
				if (IsPrime(i) == true)
				{
					sum += i;
					count++;
				}
			}
			return sum;
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
