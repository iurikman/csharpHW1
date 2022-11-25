Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i<=a) 
{
    Console.WriteLine($"{i}");
    i+=2;
}