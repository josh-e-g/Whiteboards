using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
namespace PalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPalindrome_racecars()
        {
            Assert.IsFalse(Program.IsPalindrome("racecars"));
        }
    }
}
