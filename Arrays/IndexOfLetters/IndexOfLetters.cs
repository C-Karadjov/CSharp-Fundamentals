namespace IndexOfLetters
{
    using System;

    class IndexOfLetters
    {
        static void Main()
        {
            char[] letters = Console.ReadLine().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i] - 'a');
            }
        }
    }
}
