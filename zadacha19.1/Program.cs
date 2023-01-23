// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите пятизначное  число");
int number = Convert.ToInt32(Console.ReadLine());
int p = 0;
int num = number;
while (number > 0)
{
   p = p * 10 + number % 10; number /= 10;
}
if (num == p) Console.WriteLine("Являеться палиндромом");
else Console.WriteLine("Не являеться палиндромом");

