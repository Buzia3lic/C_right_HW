int[,] NewArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        } 
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"|{arr[i, j]}");
        }
        Console.WriteLine("|");
    }
}

double[] GetAverageArray(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            result[i] += arr[j, i];
        }
        result[i] = Math.Round(result[i] /= arr.GetLength(0), 1);

    }
    
    return result;
}

Console.Write("Enter number of lines: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());
int[,] newMas = NewArray(m, n, 0, 9); //я не стал делать ввод мин и макс, так как по условию этого нет
Console.WriteLine("The array: ");
PrintArray(newMas);
Console.WriteLine($"The averages fo each column is : [{String.Join("; ", GetAverageArray(newMas))}]");
