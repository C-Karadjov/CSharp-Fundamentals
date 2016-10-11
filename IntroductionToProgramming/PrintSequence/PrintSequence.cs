namespace PrintSequence
{
    using System;

    class PrintSequence
    {
        static void Main()
        {
            int number;

            for (int i = 2; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    number = i;
                }
                else
                {
                    number = -i;
                }

                Console.WriteLine(number);
            }
        }
    }
}
