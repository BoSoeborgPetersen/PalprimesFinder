using System;
using System.Collections.Generic;
using System.Text;

namespace PalprimesFinder
{
    public class Palprimes
    {
        public IEnumerable<Tuple<string, long>> Find(long rangeMin, long rangeMax, int numberBase)
        {
            var primeChecker = new PrimeNumber();
            var palindromeChecker = new Palindrome();

            for (long number = rangeMin; number < rangeMax; number++)
            {
                if (primeChecker.IsPrimeNumber(number))
                {
                    var numberInDifferentBase = Convert.ToString(number, numberBase);

                    if (palindromeChecker.IsPalindrome(numberInDifferentBase))
                        yield return new Tuple<string, long>(numberInDifferentBase, number);
                }
            }
        }
    }
}
