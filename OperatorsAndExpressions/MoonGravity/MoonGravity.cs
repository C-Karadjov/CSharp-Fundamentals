namespace MoonGravity
{
    using System;

    class MoonGravity
    {
        static void Main()
        {
            double weightOnEarth = double.Parse(Console.ReadLine());

            double weightOnMoon = (weightOnEarth / 100) * 17;

            Console.WriteLine("{0:F3}", weightOnMoon);
        }
    }
}
