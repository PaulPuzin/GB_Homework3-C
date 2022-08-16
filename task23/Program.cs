// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int x = Convert.ToInt32(Console.ReadLine());
int n = 1;
double t = 0;
while (n<=x)
{
t=Math.Pow(n,3);
Console.WriteLine(t);
n=n+1;
}