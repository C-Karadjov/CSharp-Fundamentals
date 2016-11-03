namespace FrequentNumber
{
    using System;

    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int count = 1;
            int maxCount = int.MinValue;
            int freqNumber = 0;

            Array.Sort(numbers);

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    freqNumber = numbers[i];
                }
            }
            if (numbers.Length == 1)
            {
                maxCount = 1;
                freqNumber = numbers[0];
            }
            Console.WriteLine("{0} ({1} times)", freqNumber, maxCount);
        }
    }
}
