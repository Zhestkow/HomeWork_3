// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();
found:

WriteLine("Введите число: ");
int num = Convert.ToInt32(ReadLine());
int idx = 1;
if (num == 0)
{
    WriteLine("Вы ввели 0, пожалуйста введите другое число ");

    goto found;
}
Write($"{num} -> ");
while (idx<num)
{

    Write($"{Math.Pow(idx,3)}, ");
    idx++;
}
if (idx==num)
{
    Write($"{Math.Pow(idx,3)}");
}