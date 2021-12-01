using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"{distance(0, 0, 3, 3)}");
    }
    public static double distance(int x1, int y1, int x2, int y2)
    {
        double ans = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

        return ans;
    } 
}