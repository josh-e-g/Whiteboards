using Microsoft.VisualStudio.TestTools.UnitTesting;
using JulianDate;

namespace JulianDateTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestJulian_Jan()
		{
			Assert.AreEqual(1, Program.GetJulian(Program.Month.Jan, 1));
		}
	}
}
