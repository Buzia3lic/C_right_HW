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

int MinSum(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
    }

    int min = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < sum[i - 1]) min = i;
    }
    return min;
}


Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());
if (m == n)
{
    Console.WriteLine($"Line and column cannot be equal!");
}
else
{
    int[,] newArray = GetArrey(m, n);
    PrintArr(newArray);
    Console.WriteLine();
    int minLine = MinSum(newArray);
    Console.WriteLine($"Min sum in the [{minLine}] line.");
}