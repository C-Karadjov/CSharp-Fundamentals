namespace CompareCharArrays
{
    using System;

    class CompareCharArrays
    {
        static void Main()
        {
            string firstText = Console.ReadLine();
            char[] firstArr = firstText.ToCharArray();

            string secondText = Console.ReadLine();
            char[] secondArr = secondText.ToCharArray();

            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine(">");
            }
            else
            {
                string result = string.Empty;
                for (int i = 0; i < firstText.Length; i++)
                {
                    if (firstArr[i] == secondArr[i])
                    {
                        result = "=";
                    }
                    else if (firstArr[i] < secondArr[i])
                    {
                        result = "<";
                    }
                    else if (firstArr[i] > secondArr[i])
                    {
                        result = ">";
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
