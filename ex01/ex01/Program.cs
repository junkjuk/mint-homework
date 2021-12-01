using System;

String line = Console.ReadLine();

double way = Convert.ToDouble(Console.ReadLine());

String[] costs = line.Split(' ');

foreach (var s in costs)
{
    double anser = way / Convert.ToDouble(s);
    Console.WriteLine($"For this tank used: {anser}");
}