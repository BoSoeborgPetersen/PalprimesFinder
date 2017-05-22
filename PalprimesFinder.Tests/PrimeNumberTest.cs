using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PalprimesFinder.Tests
{
    [TestClass]
    public class PrimeNumberTest
    {
        PrimeNumber primeNumber = new PrimeNumber();

        [TestMethod]
        public void IsPrimeNumber()
        {
            Assert.IsFalse(primeNumber.IsPrimeNumber(-234));
            Assert.IsFalse(primeNumber.IsPrimeNumber(0));
            Assert.IsTrue(primeNumber.IsPrimeNumber(2));
            Assert.IsTrue(primeNumber.IsPrimeNumber(3));
            Assert.IsTrue(primeNumber.IsPrimeNumber(5));
            Assert.IsTrue(primeNumber.IsPrimeNumber(11));
            Assert.IsFalse(primeNumber.IsPrimeNumber(4));
            Assert.IsFalse(primeNumber.IsPrimeNumber(9));
            Assert.IsFalse(primeNumber.IsPrimeNumber(16));
            Assert.IsFalse(primeNumber.IsPrimeNumber(345));
            Assert.IsFalse(primeNumber.IsPrimeNumber(956));
        }
    }
}
