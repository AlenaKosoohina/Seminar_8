using System.Diagnostics.CodeAnalysis;
using System.Globalization;

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());
int[,] a = new int[n, n];
int[,] b = new int[n, n];
int[,] pr = new int[n, n];
Random rnd = new Random();
Console.WriteLine("Массив 1");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = rnd.Next(10);
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Массив 2");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        b[i, j] = rnd.Next(10);
        Console.Write($"{b[i, j]} ");
    }
    Console.WriteLine();
}
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(1); k++)
        { pr[i, j] += a[i, k] * b[k, j]; }
    }
}
Console.WriteLine();
Console.WriteLine("Произведение");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{pr[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
