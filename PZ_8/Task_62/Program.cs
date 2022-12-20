int n = 4;
int[,] array = new int[n, n];
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }

    for (int ik = 0; ik < array.GetLength(0); ik++)
    {
        for (int jk = 0; jk < array.GetLength(1); jk++)
        {
            if (array[ik, jk] < 10)
            {
                Console.Write("0" + array[ik, jk]);
                Console.Write(" ");
            }
            else Console.Write(array[ik, jk] + " ");
        }
        Console.WriteLine();
    }
