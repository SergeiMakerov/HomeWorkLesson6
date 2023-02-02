/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите колличество М чисел : ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < m; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"количество чисел больше 0: {count}");







