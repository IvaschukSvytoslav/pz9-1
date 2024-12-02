using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть значення x:");
        double x = Convert.ToDouble(Console.ReadLine());

        // Лямбда-вирази
        Func<double, double> positiveF = x => Math.Cos(x + 1);
        Func<double, double> nonPositiveF = x => 1 - 2 * Math.Sin(x);

        // Обчислення результату
        double result = x > 0 ? positiveF(x) : nonPositiveF(x);

        Console.WriteLine($"F({x}) = {result}");
    }
}
