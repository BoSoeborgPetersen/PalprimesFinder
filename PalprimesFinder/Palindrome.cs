using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalprimesFinder
{
    public class Palindrome
    {
        /**
         * Returns True if string 's' is a Palindrome.
         **/
        public bool IsPalindrome(string s)
        {
            return s != null && s.Equals(new string(s.Reverse().ToArray()));
        }
    }
}
