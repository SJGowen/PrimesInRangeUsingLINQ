namespace PrimesInRange;

internal class Primes
{

    public static IEnumerable<int> Generate(int minimum, int maximum)
    {
        IEnumerable<int> primes =
        Enumerable.Range(2, Int32.MaxValue - 1)
        .Where(number =>
            Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
            .All(divisor => number % divisor != 0));

        return primes
            .SkipWhile(min => min < minimum)
            .TakeWhile(max => max <= maximum)
            .ToList();
    }
}