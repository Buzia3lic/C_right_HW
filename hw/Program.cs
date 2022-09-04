int[,] GetArrey(int m, int n)
{
    int[,] result = new int[m, n];
    int count = m * n;
    int timer = 1;
    for (int i = 0; count >= 0; i++)
    {
        
       
        for (int j = i; j < result.GetLength(1) - i; j++)
        {
            result[i, j] = timer;
            timer++;
            count--;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int j = i; j < result.GetLength(0) - 2 - i; j++)
        {
            result[j + 1, result.GetLength(1) - 1 - i] = timer;
            timer++;
            count--;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int j = result.GetLength(1) - 1 - i; j >= i; j--)
        {
            result[result.GetLength(0) - 1 - i, j] = timer;
            timer++;
            count--;
        }
        if (count == 0) break;
        for (int j = result.GetLength(0) - 2 - i; j > i; j--)
        {
            result[j, i] = timer;
            timer++;
            count--;
            if (count == 0) break;
        }
        if (count == 0) break;
    }


    return result;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10) Console.Write($"{arr[i, j]}  ");
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

int[,] theArray = GetArrey(m, n);
PrintArr(theArray);