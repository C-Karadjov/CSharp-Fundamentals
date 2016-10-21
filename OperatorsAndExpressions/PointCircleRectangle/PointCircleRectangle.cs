namespace PointCircleRectangle
{
    using System;

    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double xcircle = 1;
            double ycircle = 1;
            double rcircle = 1.5;

            double top = 1;
            double left = -1;
            double width = 6;
            double height = 2;

            bool circle = ((x - xcircle) * (x - xcircle) + (y - ycircle) * (y - ycircle) <= (rcircle * rcircle));
            bool rectangle = (x >= left) && (x <= (left + width)) && (y >= (top - height)) && (y <= top);

            Console.Write(circle ? "inside circle " : "outside circle ");
            Console.Write(rectangle ? "inside rectangle " : "outside rectangle ");
        }
    }
}
