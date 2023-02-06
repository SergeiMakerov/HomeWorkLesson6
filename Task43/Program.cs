/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

PrintResult();

double GetX(double b1, double b2, double k1, double k2)
{
    return (-b2 + b1) / (-k1 + k2);
}

double GetY(double x, double b2, double k2)
{
    return k2 * x + b2;
}

void PrintResult()
{
    Console.WriteLine($"Координаты точки пересечения двух прямых X: {GetX(b1, b2, k1, k2)}, Y: {GetY(GetX(b1, b2, k1, k2), b2, k2)})");
}
