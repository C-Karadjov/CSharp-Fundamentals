namespace CompareArrays
{
    using System;

    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            bool isEqual = false;
            for (int j = 0; j < n; j++)
            {
                if (firstArr[j] == secondArr[j])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
            Console.WriteLine(isEqual ? "Equal" : "Not equal");
        }
    }
}
