using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PalprimesFinder.Tests
{
    [TestClass]
    public class PalindromeTest
    {
        Palindrome palindrome = new Palindrome();

        [TestMethod]
        public void IsPalindromeTest()
        {
            Assert.IsFalse(palindrome.IsPalindrome("98587"));
            Assert.IsFalse(palindrome.IsPalindrome("7847"));
            Assert.IsTrue(palindrome.IsPalindrome("4334"));
            Assert.IsTrue(palindrome.IsPalindrome("131"));
            Assert.IsFalse(palindrome.IsPalindrome(null));
            Assert.IsTrue(palindrome.IsPalindrome(""));
            Assert.IsFalse(palindrome.IsPalindrome(" 131"));
            Assert.IsFalse(palindrome.IsPalindrome(" 433"));
            Assert.IsFalse(palindrome.IsPalindrome("131 "));
            Assert.IsFalse(palindrome.IsPalindrome("433 "));
            Assert.IsFalse(palindrome.IsPalindrome("1 31"));
            Assert.IsFalse(palindrome.IsPalindrome("43 3"));
            Assert.IsTrue(palindrome.IsPalindrome("4 3 4"));
            Assert.IsTrue(palindrome.IsPalindrome(" 434 "));
        }
    }
}
