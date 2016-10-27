namespace MMSAOfNNumbers
{
    using System;

    class MMSAOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers > max)
                {
                    max = numbers;
                }
                if (numbers < min)
                {
                    min = numbers;
                }

            }
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum / n);
        }
    }
}
