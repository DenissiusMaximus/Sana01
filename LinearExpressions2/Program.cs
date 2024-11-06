﻿class Program
{
    public static void Main()
    {
        double z1, z2;
        double m, n, a, b, x, y;

        Console.Write("m: ");
        m = double.Parse(Console.ReadLine());
        Console.Write("n: ");
        n = double.Parse(Console.ReadLine());
        Console.Write("a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());

        z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
                    (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);

        z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

        y = 2.4 * (Math.Abs(Math.Pow(x, 2) + b) / a) +
                   (a - b) * Math.Pow(Math.Sin(a - b), 2) +
                   Math.Pow(10, -2) * (x - b);

        Console.WriteLine("z1 = " + z1);
        Console.WriteLine("z2 = " + z2);
        Console.WriteLine("y = " + y);
    }
}