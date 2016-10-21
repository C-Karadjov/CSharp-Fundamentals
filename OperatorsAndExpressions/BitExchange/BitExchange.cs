namespace BitExchange
{
    using System;

    class BitExchange
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            ulong masc = 1 << 3;
            ulong thirdBit = (number & masc) >> 3;

            masc = 1 << 24;
            ulong twentyFourthBit = (number & masc) >> 24;

            if (thirdBit == 0)
            {
                masc = ~((ulong)1 << 24);
                number = number & masc;
            }
            else if (thirdBit==1)
            {
                masc = (1 << 24);
                number = number | masc;
            }
            if (twentyFourthBit == 0)
            {
                masc = ~((ulong)1 << 3);
                number = number & masc;
            }
            else if (twentyFourthBit == 1)
            {
                masc = (1 << 3);
                number = number | masc;
            }

            masc = 1 << 4;
            ulong fourthBit = (number & masc) >> 4;

            masc = 1 << 25;
            ulong twentyFifthBit = (number & masc) >> 25;

            if (fourthBit == 0)
            {
                masc = ~((ulong)1 << 25);
                number = number & masc;
            }
            else if (fourthBit == 1)
            {
                masc = (1 << 25);
                number = number | masc;
            }
            if (twentyFifthBit == 0)
            {
                masc = ~((ulong)1 << 4);
                number = number & masc;
            }
            else if (twentyFifthBit == 1)
            {
                masc = (1 << 4);
                number = number | masc;
            }

            masc = 1 << 5;
            ulong fifthBit = (number & masc) >> 5;

            masc = 1 << 26;
            ulong twentySixthBit = (number & masc) >> 26;

            if (fifthBit == 0)
            {
                masc = ~((ulong)1 << 26);
                number = number & masc;
            }
            else if (fifthBit == 1)
            {
                masc = (1 << 26);
                number = number | masc;
            }
            if (twentySixthBit == 0)
            {
                masc = ~((ulong)1 << 5);
                number = number & masc;
            }
            else if (twentySixthBit == 1)
            {
                masc = (1 << 5);
                number = number | masc;
            }

            Console.WriteLine(number);
        }
    }
}
