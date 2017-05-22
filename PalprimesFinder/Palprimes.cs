using System;
using System.Collections.Generic;
using System.Text;

namespace PalprimesFinder
{
    public class Palprimes
    {
        /**
         * Find all primes in range (between 'rangeMin' and 'rangeMax'), 
         * that are also palindromes in the 'numberBase' specified.
         **/
        public IEnumerable<Tuple<string, long>> Find(long rangeMin, long rangeMax, int numberBase)
        {
            if (rangeMax < rangeMin) yield break;
            if (numberBase < 2) yield break;

            var primeChecker = new PrimeNumber();
            var palindromeChecker = new Palindrome();

            // Goes through the numbers between 'rangeMin' and 'rangeMax'.
            for (long number = rangeMin; number < rangeMax; number++)
            {
                // Checks if the number is a prime number.
                if (primeChecker.IsPrimeNumber(number))
                {
                    // Converts number to different numbering base string.
                    var numberInDifferentBase = Convert.ToString(number, numberBase);

                    // Checks if the number is a palindrome (in the different number base), 
                    // and if so returns the numbers as part of collection returned.
                    if (palindromeChecker.IsPalindrome(numberInDifferentBase))
                        yield return new Tuple<string, long>(numberInDifferentBase, number);
                }
            }
        }
    }
}
