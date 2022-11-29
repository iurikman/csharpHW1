/*

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите число четверт (от 1 до 4)");
        }
    }

    return result;
}


int GetRes(int x) 
{
    int res = x*x;
    return res;
}

int x = GetNumber("Введите число");

int i = 1;
while (i <= x) {
    int rev = GetRes(i);
    Console.Write($"{rev}, ");
    i++;
}
