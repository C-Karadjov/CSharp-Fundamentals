namespace BonusScore
{
    using System;

    class BonusScore
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number <= 3)
            {
                number *= 10;
                Console.WriteLine(number);
            }
            else if (number > 3 && number <= 6)
            {
                number *= 100;
                Console.WriteLine(number);
            }
            else if (number > 6 && number <= 9)
            {
                number *= 1000;
                Console.WriteLine(number);
            }
            else 
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
