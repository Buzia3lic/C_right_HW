int[,] GetArrey(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] DecreaseArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int i1 = 0; i1 < arr.GetLength(1); i1++) 
        {
            for (int j = arr.GetLength(1) - 1; j > 0; j--)
            {
                if (arr[i, j] > arr[i, j - 1]) (arr[i, j], arr[i, j - 1]) = (arr[i, j - 1], arr[i, j]);
            }
        }
    }
    return arr;
}

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

int[,] newArray = GetArrey(m, n);
PrintArr(newArray);
Console.WriteLine();
int[,] decrArray = DecreaseArrey(newArray);
PrintArr(decrArray);