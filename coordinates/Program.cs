// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равно 0 и Y не равно 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int CalculateQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else 
        return -1;
}

Console.WriteLine("Программа для вычисления номера четверти плоскости");
Console.WriteLine("Введите координату Х: ");
if (!int.TryParse(Console.ReadLine(), out var x))
    Console.WriteLine("Введено не целое число");

Console.WriteLine("Введите координату Y: ");
if (!int.TryParse (Console.ReadLine(), out var y))
    Console.WriteLine("Введено не целое число");

if (x == 0 || y == 0) 
{
    Console.WriteLine("Точка не должна лежать на оси");
    return;
}
var result = CalculateQuarter(x, y);
if (result != -1)
    Console.WriteLine($"Точка ({x}, {y}) находится в четверти {result}");
else 
    Console.WriteLine("Ошибка при вычислении, входные данные не верны");