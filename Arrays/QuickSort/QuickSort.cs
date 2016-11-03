namespace QuickSort
{
    using System;

    class QuickSort
    {
        static void QuickSortRecursive(int[] arr, int left, int right)
        {
            int pivotIndex = (left + right) / 2;
            int leftIndex = left;
            int rightIndex = right;
            int pivot = arr[pivotIndex];

            while (leftIndex <= rightIndex)
            {
                while (arr[leftIndex] < pivot)
                {
                    leftIndex++;
                }

                while (arr[rightIndex] > pivot)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    int swap = arr[leftIndex];
                    arr[leftIndex] = arr[rightIndex];
                    arr[rightIndex] = swap;

                    leftIndex++;
                    rightIndex--;
                }

                if (left < rightIndex)
                {
                    QuickSortRecursive(arr, left, rightIndex);
                }

                if (leftIndex < right)
                {
                    QuickSortRecursive(arr, leftIndex, right);
                }
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            //Input
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Sorting
            QuickSortRecursive(array, 0, n - 1);

            //Output
            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}
