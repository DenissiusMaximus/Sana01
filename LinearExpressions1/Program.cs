
class Program
{
    public static void Main()
    {
        double a, b, c, d;
        double x, y, z, r;

        Console.Write("a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        c = double.Parse(Console.ReadLine());
        Console.Write("d: ");
        d = double.Parse(Console.ReadLine());

        x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
        y = (5 * (a + b) * (c - d)) / (0.5 * c) + (Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
        z = Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * ((Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
        r = (0.5 * a + 0.75 * b - 7.0 / 5) / (3 * c + 1) + (1 / (a - c));

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("z = " + z);
        Console.WriteLine("r = " + r);
    }
}
