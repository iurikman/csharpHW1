Console.WriteLine("введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b) Console.WriteLine("числа равны");
else 
{
if (a>b) Console.WriteLine("число 1 болье числа 2");
else Console.WriteLine("число 2 болье числа 1");
}