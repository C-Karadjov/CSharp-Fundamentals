namespace ThirdDigit
{
    using System;
    using System.Collections.Generic;

    class ThirdDigit
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int result = ((numbers / 100) % 10);

            if (result==7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", result);
            }
        }
    }
}
