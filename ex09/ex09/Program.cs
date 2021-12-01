using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"{celsius(0)}");
        Console.WriteLine($"{celsius(100)}");
        Console.WriteLine($"{fahrenheit(32)}");
        Console.WriteLine($"{fahrenheit(212)}");
    }
    public static double celsius(double temperature)
    {
        temperature = 32 + temperature * 1.8;

        return temperature;
    }

    public static double fahrenheit(double temperature)
    {
        temperature -= 32;
        temperature /= 1.8;
        return temperature;
    }
}