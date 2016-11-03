namespace MaximalSequence
{
    using System;

    class MaximalSequence
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
            int maxLenght = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    maxLenght = Math.Max(count, maxLenght);
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxLenght);
        }
    }
}
