using System;

class Program
{
    static void Main(string[] args)
    {
        double x1 = 3;
        double y1 = 3;
        double x2 = -3;
        double y2 = 3;

        double x3 = -9;
        double y3 = 9;
        double x4 = 9;
        double y4 = 17;

        double a1 = y2 - y1;
        double b1 = x1 - x2;
        double c1 = a1 * x1 + b1 * y1;

        double a2 = y4 - y3;
        double b2 = x3 - x4;
        double c2 = a2 * x3 + b2 * y3;

        double deter = a1 * b2 - a2 * b1;

        if (deter == 0)
        {
            Console.WriteLine("Прямые не пересекаются");
        }
        else
        {
            double x = (b2 * c1 - b1 * c2) / deter;
            double y = (a1 * c2 - a2 * c1) / deter;
            Console.WriteLine("Прямые пересекаются в точке ({0}, {1})", x, y);
        }
    }
}