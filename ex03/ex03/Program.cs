using System;

int number = Convert.ToInt32(Console.ReadLine());

int anser = number / 10000;

if (anser == number % 10)
{
  number -= anser * 10000;
  number /= 10;
  
  anser = number / 100;
  if (anser == number % 10) 
  { 
      Console.WriteLine("YES");
      return;
  }     
}
Console.WriteLine("NO");