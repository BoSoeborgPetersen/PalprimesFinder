using System;
using System.Collections.Generic;
using System.Text;

namespace PalprimesFinder
{
    public class Palprimes
    {
        public IEnumerable<Tuple<string, long>> Find(long rangeMin, long rangeMax, int numberBase)
        {
            var changeBase = new NumberBase();
            var primeChecker = new PrimeNumber();
            var palindromeChecker = new Palindrome();

            for (long number = rangeMin; number < rangeMax; number++)
                if (primeChecker.IsPrimeNumber(number))
                {
                    string numberInDifferentBase = changeBase.ConvertDecimalToOtherBase(number, numberBase);

                    if (palindromeChecker.IsPalindrome(numberInDifferentBase))
                        yield return new Tuple<string, long>(numberInDifferentBase, number);
                }
        }
    }
}
