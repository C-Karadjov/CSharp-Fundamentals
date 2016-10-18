namespace ComparingFloats
{
    using System;

    class ComparingFloats
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double result = Math.Abs(firstNumber - secondNumber);

            if (result < eps)
            {
                Console.WriteLine("true");
            }
            if (result > eps)
            {
                Console.WriteLine("false");
            }
        }
    }
}
