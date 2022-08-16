// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int x = Convert.ToInt32(Console.ReadLine());
int t = x/10000;
int c = x%10;
int b = (x/1000)%10;
int a = (x/10)%10;
if (x>=10000 && x<=99999 && t==c && b==a)
Console.WriteLine("yes");
else 
{Console.WriteLine("no");}