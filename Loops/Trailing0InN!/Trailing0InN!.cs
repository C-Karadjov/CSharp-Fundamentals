namespace Trailing0InN_
{
    using System;

    class Trailing0InN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int divider = 5;
            int count = 0;

            while ((n / divider) >= 1)
            {
                count += (n / divider);
                divider *= 5;
            }
            Console.WriteLine(count);
        }
    }
}

