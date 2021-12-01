using System;


int numb = Convert.ToInt32(Console.ReadLine());
int anser1 = 1;
for (int i = 1; i <= numb; i++)
{
    anser1 *= i;
}


Console.WriteLine($"A: {anser1}");
double anser2 = 1;
double constant = 1;
for (int i = 1; i < 10000; i++)
{
    constant *= i;
    anser2 += 1/constant;
}
Console.WriteLine($"B: {anser2}");
double x = 3;
int iter = 3;
double anser3 = 1;
double constant2 = 1;
for (int i = 1; i <= iter; i++)
{

    constant2 *= i;
    anser3 += x/constant2;
    x *= iter;
}
Console.WriteLine($"C: {anser3}");
