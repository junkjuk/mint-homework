using System;


double hours = Convert.ToDouble(Console.ReadLine());
double costs = Convert.ToDouble(Console.ReadLine());
double anser;
if (hours > 40)
{
    anser = 40 * costs;
    anser += costs * (hours - 40) * 1.5;
}
else
{
    anser = hours * costs;
}
Console.WriteLine($"Salary: ${anser}");