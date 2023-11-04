const long rangeMin = 1;
const long rangeMax = 10000000;
const int defaultNumberBase = 10;

int.TryParse(args?.FirstOrDefault(), out int numberBase);
if (numberBase == 0) numberBase = defaultNumberBase;

var palprimesFinder = new Palprime();

var palprimes = palprimesFinder.Find(rangeMin, rangeMax, numberBase);

var baseString = (numberBase == 10 ? "" : "(base " + numberBase + ")");
var dataString = string.Join(",", palprimes.Select(pp => pp.Item1 + (numberBase == 10 ? "" : "(" + pp.Item2 + ")")));
Console.WriteLine($"Palindrome primes {baseString}: [{dataString}]");

Console.ReadLine();
