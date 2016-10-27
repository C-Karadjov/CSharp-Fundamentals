namespace OddAndEvenProduct
{
    using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var numbers = input.Split(' ');

            long oddProduct = 1;
            long evenProduct = 1;

            for (int i = 1; i < numbers.Length + 1; i++)
            {
                if (i % 2 != 0)
                {
                    oddProduct *= int.Parse(numbers[i - 1]);
                }
                else
                {
                    evenProduct *= int.Parse(numbers[i - 1]);
                }
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes {0}", evenProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}
