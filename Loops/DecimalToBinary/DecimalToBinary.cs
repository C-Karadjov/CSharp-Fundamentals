namespace DecimalToBinary
{
    using System;
    using System.Numerics;

    class DecimalToBinary
    {
        static void Main()
        {
            BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());

            string binaryNumber = string.Empty;

            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber = digit + binaryNumber;
                decimalNumber /= 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}
