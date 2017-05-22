using System;
using System.Collections.Generic;

namespace PalprimesFinder
{
    public class Program
    {
        public const long rangeMin = 1;
        public const long rangeMax = 1000;
        public const int defaultNumberBase = 16;

        public static void Main(string[] args)
        {
            int numberBase = defaultNumberBase;
            if (args != null && args.Length == 1 && !string.IsNullOrWhiteSpace(args[0]))
                if (!int.TryParse(args[0], out numberBase))
                    numberBase = defaultNumberBase;

            var palprimesFinder = new Palprimes();

            IEnumerable<Tuple<string, long>> palprimes = palprimesFinder.Find(rangeMin, rangeMax, numberBase);

            foreach(Tuple<string, long> palprime in palprimes)
                Console.WriteLine(palprime.Item1 + " " + (numberBase == 10 ? "" : "(" + palprime.Item2 + ")") + " is a palprime");

            Console.ReadLine();
        }
    }
}