using System.Diagnostics.CodeAnalysis;
using System.Globalization;

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
int[] sum = new int[n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] = sum[i] + array[i, j];
    }
}
Console.WriteLine();
int min = sum[0];
int index = 0;
for (int i = 0; i < n; i++)
{
    if (min > sum[i]) { min = sum[i]; index = i; }
    //Console.Write($"{sum[i]} ");
}
Console.WriteLine();
Console.WriteLine($"{index} строка");