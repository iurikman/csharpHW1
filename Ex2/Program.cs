﻿Console.WriteLine("введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 3");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b>max && b>c) max = b;
else 
{
    if (c>a) max = c;
}
Console.WriteLine($"{max}");
