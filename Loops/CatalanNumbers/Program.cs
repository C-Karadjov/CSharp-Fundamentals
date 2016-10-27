namespace CatalanNumbers
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger numerator = 1;

            for (int i = 1; i <= (2 * n); i++)
            {
                numerator *= i;
            }
            BigInteger denumerator = 1;
            for (int i = 1; i <= (n + 1); i++)
            {
                denumerator *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                denumerator *= i;
            }
            Console.WriteLine(numerator / denumerator);
        }
    }
}
