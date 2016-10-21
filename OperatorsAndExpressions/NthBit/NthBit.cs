namespace NthBit
{
    using System;

    class NthBit
    {
        static void Main()
        {
            long number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int masc = 1 << position;
            long numberAndMasc = number & masc;
            long bit = numberAndMasc >> position;
            Console.WriteLine(bit);
        }
    }
}
