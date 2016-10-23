namespace IntDoubleString
{
    using System;

    class IntDoubleString
    {
        static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    {
                        int number = int.Parse(Console.ReadLine());
                        number++;
                        Console.WriteLine(number);
                    }
                    break;
                case "real":
                    {
                        double real = double.Parse(Console.ReadLine());
                        real++;
                        Console.WriteLine("{0:F2}", real);
                    }
                    break;
                case "text":
                    {
                        string text = Console.ReadLine();
                        Console.WriteLine("{0}", text + "*");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
