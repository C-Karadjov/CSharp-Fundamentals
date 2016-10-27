namespace Calculate
{
    using System;
    using System.Numerics;

    class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += (double)factorial / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
