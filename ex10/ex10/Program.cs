using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"{revers(7631)}");
    }
    public static int revers(int numb)
    {
        int ans = 0;
        while (numb != 0)
        {
            ans += numb % 10;
            numb /= 10;
            ans *= 10;
        } 

        return ans/10;
    } 
}