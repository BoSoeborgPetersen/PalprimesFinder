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
            if (number == 2 || number == 3) return true;
            if (number == 1 || number % 2 == 0 || number % 3 == 0) return false;

            for (long i = 5, w = 2; i*i <= number; i += w, w = 6 - w)
                if (number % i == 0) return false;

            return true;
        }
    }
}
