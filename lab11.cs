using System;
using System.Collections.Generic;
class Program
{
    private static double GetaAverage(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
    private static double GetCylinderVolume(double radius, double height)
    {
        var volume = Math.PI * Math.Pow(radius, 2) * height;
        return volume;
    }
    //n * 9/5 + 32 = F
    private static IEnumerable<string> GetTableFahrenheitByCelsius(double[] celsius)
    {
        for (int i = 0; i < celsius.Length; i++)
        {
            var fahrenheit = celsius[i] * 9 / 5 + 32;
            yield return $"{celsius[i]}C\t{fahrenheit}F";
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------------------------");
        Console.Write("Enter a: ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        var c = double.Parse(Console.ReadLine());
        Console.WriteLine($"Average: ({a} + {b} + {c}) / 3 = {GetaAverage(a, b, c)}");

        Console.WriteLine("--------------------------------------------------------------------");
        Console.Write("Enter radius: ");
        var radius = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        var height = double.Parse(Console.ReadLine());
        Console.WriteLine($"Volume Cylinder: PI * {radius}^2 * {height} = {GetCylinderVolume(radius, height)}");

        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine($"How many temperature you wanna enter:");
        var count = int.Parse(Console.ReadLine());
        var celsius = new double[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter temperature: ");
            celsius[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nC\tF\n-----------------");
        foreach (var item in GetTableFahrenheitByCelsius(celsius))
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------------------------------------------------");
        Console.ReadKey();
    }
}
