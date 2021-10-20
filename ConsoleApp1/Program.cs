using System;
using System.Runtime;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b ,c, d;
            double x, y, z, r;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());

            x = ((a + 2 * b - c + d) / c * d) + ((a + b) / (c - d)) - (a * a / b * b);
            y = (5 * (a + b) * (c - d)) / (0.5 * c) + d * d * ((a * a - b * b) / b - a);
            z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) * (1 - b))) / 5 * a + 3 * b;
            r = ((1 / 2 * a + 3 / 4 * b - 7 / 5) / 3 * c + 1) + 1 / a - c;
            Console.WriteLine($"x = {x}\ny = {y}\nz = {z}\nr = {r}\n");
        }
    }
}
