using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalprimesFinder.Tests
{
    [TestClass]
    public class PalprimesTest
    {
        public const long rangeMin = 1;
        public const long rangeMax = 1000;
        private Palprimes palprimesFinder = new Palprimes();
        private List<long> decimalPalprimes = new List<long>()
        {
            2, 3, 5, 7, 11, 101, 131, 151, 181, 191, 313, 353, 373, 383, 727, 757, 787, 797, 919, 929
        };
        private List<string> binaryPalprimes = new List<string>()
        {
            "11", "101", "111", "10001", "11111", "1001001", "1101011", "1111111", "100000001", "100111001", "110111011"
        };
        private List<string> hexPalprimes = new List<string>()
        {
            "2", "3", "5", "7", "b", "d", "11", "101", "151", "161", "191", "1b1", "1c1", "313", "373", "3b3"
        };

        [TestMethod]
        public void FindDecimalTest()
        {
            IEnumerable<Tuple<string, long>> palprimes = palprimesFinder.Find(rangeMin, rangeMax, 10);

            Assert.AreEqual(decimalPalprimes.Count, palprimes.Count());

            Assert.IsTrue(Enumerable.SequenceEqual(decimalPalprimes, palprimes.Select(x => x.Item2).ToList()));
        }

        [TestMethod]
        public void FindBinaryTest()
        {
            IEnumerable<Tuple<string, long>> palprimes = palprimesFinder.Find(rangeMin, rangeMax, 2);

            Assert.AreEqual(binaryPalprimes.Count, palprimes.Count());

            Assert.IsTrue(Enumerable.SequenceEqual(binaryPalprimes, palprimes.Select(x => x.Item1).ToList()));
        }

        [TestMethod]
        public void FindHexTest()
        {
            IEnumerable<Tuple<string, long>> palprimes = palprimesFinder.Find(rangeMin, rangeMax, 16);

            Assert.AreEqual(hexPalprimes.Count, palprimes.Count());

            Assert.IsTrue(Enumerable.SequenceEqual(hexPalprimes, palprimes.Select(x => x.Item1).ToList()));
        }
    }
}
