/*

Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

             |
      2      |       1
             |
-------------------------->
             |
      3      |       4
*/

//функция получения числа с консоли


int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5)
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

//получение четверти, в которой лежит точка с координатами (x, y)

string GetQuarter(int x)
{
    if(x == 1)
        return "x > 0 && y > 0";
    else if(x == 2)
        return "x < 0 && y > 0";
    else if(x == 3)
        return "x < 0 && y < 0";
    else
        return "x > 0 && y < 0";
}

int x = GetNumber("Введите четверть:");

string quarter = GetQuarter(x);

Console.WriteLine($"{quarter}");

