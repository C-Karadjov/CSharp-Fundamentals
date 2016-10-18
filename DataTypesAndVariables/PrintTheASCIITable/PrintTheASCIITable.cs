namespace PrintTheASCIITable
{
    using System;

    class PrintTheASCIITable
    {
        static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                char ch = Convert.ToChar(i);
                Console.Write(ch);
            }
        }
    }
}
