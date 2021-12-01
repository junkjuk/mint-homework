using System;

int anser = 1;
for (int i = 1; i <= 15; i++)
{
    if (i%2 != 0)
    {
        anser *= i;
    }
}
Console.WriteLine($"{anser}");