namespace PalprimesFinder;

public class Palprime
{
    public bool IsPalindrome(string s) => s == new string(s.Reverse().ToArray());

    public bool IsPrimeNumber(long number)
    {
        if (number == 2 || number == 3) return true;
        if (number <= 1 || number % 2 == 0 || number % 3 == 0) return false;
        for (long i = 5, w = 2; i * i <= number; i += w, w = 6 - w)
            if (number % i == 0) return false;

        return true;
    }

    public IEnumerable<Tuple<string, long>> Find(long rangeMin, long rangeMax, int numberBase = 10)
    {
        if (rangeMax<rangeMin) yield break;
        if (numberBase< 2) yield break;

        for (long number = rangeMin; number<rangeMax; number++)
        {
            var numberInDifferentBase = Convert.ToString(number, numberBase);

            if (IsPalindrome(numberInDifferentBase))
                if (IsPrimeNumber(number))
                    yield return new Tuple<string, long>(numberInDifferentBase, number);
        }
    }
}
