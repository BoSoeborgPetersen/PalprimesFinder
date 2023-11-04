namespace PalprimesFinder.Tests;

[TestClass]
public class PalprimesTest
{
    private Palprime palprime = new();

    [TestMethod]
    [DataRow("4334")]
    [DataRow("131")]
    [DataRow("")]
    [DataRow("4 3 4")]
    [DataRow(" 434 ")]
    public void IsPalindrome(string s)
    {
        Assert.IsTrue(palprime.IsPalindrome(s));
    }

    [TestMethod]
    [DataRow("98587")]
    [DataRow("7847")]
    [DataRow(" 131")]
    [DataRow(" 433")]
    [DataRow("131 ")]
    [DataRow("433 ")]
    [DataRow("1 31")]
    [DataRow("43 3")]
    public void IsNotPalindrome(string s)
    {
        Assert.IsFalse(palprime.IsPalindrome(s));
    }

    [TestMethod]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(5)]
    [DataRow(11)]
    public void IsPrime(long n)
    {
        Assert.IsTrue(palprime.IsPrimeNumber(n));
    }

    [TestMethod]
    [DataRow(-234)]
    [DataRow(0)]
    [DataRow(4)]
    [DataRow(9)]
    [DataRow(16)]
    [DataRow(345)]
    [DataRow(956)]
    public void IsNotPrime(long n)
    {
        Assert.IsFalse(palprime.IsPrimeNumber(n));
    }

    [TestMethod]
    public void FindDecimalTest()
    {
        var expected = new List<long>() { 2, 3, 5, 7, 11, 101, 131, 151, 181, 191, 313, 353, 373, 383, 727, 757, 787, 797, 919, 929 };
        var actual = palprime.Find(1, 1000);

        Assert.AreEqual(expected.Count, actual.Count());

        CollectionAssert.AreEqual(expected, actual.Select(x => x.Item2).ToList());
    }

    [TestMethod]
    public void FindBinaryTest()
    {
        var expected = new List<string>() { "11", "101", "111", "10001", "11111", "1001001", "1101011", "1111111", "100000001", "100111001", "110111011" };
        var actual = palprime.Find(1, 1000, 2);

        Assert.AreEqual(expected.Count, actual.Count());

        CollectionAssert.AreEqual(expected, actual.Select(x => x.Item1).ToList());
    }

    [TestMethod]
    public void FindHexTest()
    {
        var expected = new List<string>() { "2", "3", "5", "7", "b", "d", "11", "101", "151", "161", "191", "1b1", "1c1", "313", "373", "3b3" };
        var actual = palprime.Find(1, 1000, 16);

        Assert.AreEqual(expected.Count, actual.Count());

        CollectionAssert.AreEqual(expected, actual.Select(x => x.Item1).ToList());
    }
}
