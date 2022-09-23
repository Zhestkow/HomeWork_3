// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();
WriteLine("Введите число: ");
int Num = int.Parse(ReadLine());
if (Num/10000==Num%10 && Num/1000%10==Num/10%10)
{
WriteLine($"{Num} ---> число палиндром!");
}
else
{
    WriteLine($"{Num} ---> не палиндром!");
}