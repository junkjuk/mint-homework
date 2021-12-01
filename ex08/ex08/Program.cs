using System;

class Program
{
    static void Main()
    {
        int base1 = Convert.ToInt16(Console.ReadLine());
        int exponent = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine($"{integerPower(base1, exponent)}");
    }
    public static int integerPower(int base1, int exponent)
    {
        int ans = 1;
        for (int i = 0; i < exponent; i++)
        {
            ans *= base1;
        }

        return ans;
    } 
}

