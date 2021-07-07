using PluginBase;

namespace Problems1to9
{
    /// <summary>
    /// Multiples of 3 and 5
    /// <see cref="https://projecteuler.net/problem=1"/>
    /// </summary>
    public class Problem1 : IProblem
    {
        public int Number => 1;

        public string Name => "Multiples of 3 and 5";

        public string Description =>
            "If we list all the natural numbers below 10 that are multiples of 3 or 5, " +
            "we get 3, 5, 6 and 9. The sum of these multiples is 23. /r/n" +
            "Find the sum of all the multiples of 3 or 5 below 1000.";

        public string GetSolution()
        {
            var result = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
            return result.ToString();
        }
    }
}
