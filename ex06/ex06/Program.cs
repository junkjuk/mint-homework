using System;


int n = Convert.ToInt16(Console.ReadLine());
int anser = 0;
for (int i = 0; i < n; i++)
{
    
int a = Convert.ToInt16(Console.ReadLine());
anser += a;
}

Console.WriteLine($"{anser}");