using System;

namespace JulianDate
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("JulianDate.Program.Main()");
			Console.WriteLine(GetJulian(Month.Dec, 31));
		}
		public enum Month {Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec}
		public static int GetJulian(Month month, int day)
		{
			int julian = 0;

			if (month == Month.Feb)
			{
				julian = 31;
			}
			else if (month == Month.Mar)
			{
				julian = 59;
			}
			else if (month == Month.Apr)
			{
				julian = 90;
			}
			else if (month == Month.May)
			{
				julian = 120;
			}
			else if (month == Month.Jun)
			{
				julian = 151;
			}
			else if (month == Month.Jul)
			{
				julian = 181;
			}
			else if (month == Month.Aug)
			{
				julian = 212;
			}
			else if (month == Month.Sep)
			{
				julian = 243;
			}
			else if (month == Month.Oct)
			{
				julian = 273;
			}
			else if (month == Month.Nov)
			{
				julian = 304;
			}
			else if (month == Month.Dec)
			{
				julian = 334;
			}
			return julian+day;
		}
	}
}
