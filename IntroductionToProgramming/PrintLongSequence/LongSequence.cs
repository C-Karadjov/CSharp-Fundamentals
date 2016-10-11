namespace PrintLongSequence
{
    using System;

    class LongSequence
    {
        static void Main()
        {
            int numbers;

            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    numbers = i;
                }
                else
                {
                    numbers = -i;
                }

                Console.WriteLine(numbers);
            }
        }
    }
}
