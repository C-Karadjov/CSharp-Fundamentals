namespace DecimalToHex
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class DecimalToHex
    {
        static void Main()
        {
            BigInteger decNumber = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(ToHexadecimal(decNumber, 16));
        }

        static string ToHexadecimal(BigInteger decNumber, int inputNumSystem)
        {
            string hexNumber = string.Empty;
            while (decNumber > 0)
            {
                BigInteger digit = decNumber % inputNumSystem;
                hexNumber = HexDigits[digit] + hexNumber;
                decNumber /= inputNumSystem;
            }
            return hexNumber;
        }

        static Dictionary<BigInteger, char> HexDigits = new Dictionary<BigInteger, char>()
        {
             {0,'0' },
             {1,'1' },
             {2,'2' },
             {3,'3' },
             {4,'4' },
             {5,'5' },
             {6,'6' },
             {7,'7' },
             {8,'8' },
             {9,'9' },
             {10,'A' },
             {11,'B' },
             {12,'C' },
             {13,'D' },
             {14,'E' },
             {15,'F' },
        };
    }
}
