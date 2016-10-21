namespace PrimeCheck
{
    using System;

    class PrimeCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
