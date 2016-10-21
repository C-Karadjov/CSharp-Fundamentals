namespace _3rdBit
{
    using System;

    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int pos = 3;
            int masc = 1 << pos; 
            int numberAndMasc = number & masc;
            int bit = numberAndMasc >> pos;
            Console.WriteLine(bit);
        }
    }
}
