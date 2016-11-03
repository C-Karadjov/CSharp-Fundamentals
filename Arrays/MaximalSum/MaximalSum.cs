namespace MaximalSum
{
    using System;

    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            int currentSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum += numbers[i];
                if (currentSum < numbers[i])
                {
                    currentSum = numbers[i];
                }
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
