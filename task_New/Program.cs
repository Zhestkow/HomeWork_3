// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();
WriteLine("Введите число: ");
string Num = Convert.ToString(ReadLine());
int idx = 0;
int length = Num.Length;

while (idx<length)
{
    if (Num[idx]==Num[length-(idx+1)]) 
    {
    Write($"{Num} палиндром");
    return;
    }
        else 
        {
        Write($"{Num} не палиндром");
        return;
        }
        idx++;
}
