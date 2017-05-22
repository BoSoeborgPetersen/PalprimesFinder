using System;
using System.Collections.Generic;
using System.Linq;

namespace PalprimesFinder
{
    public class Program
    {
        public const long rangeMin = 1;
        public const long rangeMax = 1000;
        public const int defaultNumberBase = 10;

        public static void Main(string[] args)
        {
            int.TryParse(args?.ElementAtOrDefault(0), out int numberBase);
            if (numberBase == 0) numberBase = defaultNumberBase;

            var palprimesFinder = new Palprimes();

            IEnumerable<Tuple<string, long>> palprimes = palprimesFinder.Find(rangeMin, rangeMax, numberBase);

            foreach(Tuple<string, long> palprime in palprimes)
                Console.WriteLine(palprime.Item1 + " " + (numberBase == 10 ? "" : "(" + palprime.Item2 + ")") + " is a palprime");

            Console.ReadLine();
        }
    }
}