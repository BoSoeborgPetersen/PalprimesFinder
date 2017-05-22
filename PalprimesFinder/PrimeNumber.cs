using System;
using System.Collections.Generic;
using System.Text;

namespace PalprimesFinder
{
    public class PrimeNumber
    {
        /**
         * Returns True if 'number' is prime.
         **/
        public bool IsPrimeNumber(long number)
        {
            // 2 & 3 are prime.
            if (number == 2 || number == 3) return true;
            // negative numbers and zero are not prime.
            // Also numbers that are divisable by 2 & 3 are not prime.
            if (number <= 1 || number % 2 == 0 || number % 3 == 0) return false;

            // Checks divisibility by odd numbers, 
            // except multiples of 3 (which is done by jumping 2, then 4, then 2, and so on)
            // Essentially except 2 and 3 all prime number can represent using (6*n)+1 or (6*n)-1.
            for (long i = 5, w = 2; i * i <= number; i += w, w = 6 - w)
                if (number % i == 0) return false;

            return true;
        }
    }
}
