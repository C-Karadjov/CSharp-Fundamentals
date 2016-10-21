namespace ModifyBit
{
    using System;

    class ModifyBit
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int bitValue = int.Parse(Console.ReadLine());

            if (bitValue==0)
            {
                ulong masc = (ulong)~(1 << position);
                ulong result = number & masc;
                Console.WriteLine(result);
            }
            else
            {
                ulong masc = (ulong)1 << position;
                ulong result = number | masc;
                Console.WriteLine(result);
            }
        }
    }
}
