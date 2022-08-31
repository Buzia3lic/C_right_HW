double[,] NewArray(int m, int n, int min, int max)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Math.Round(new Random().Next(min, max + 1) + new Random().NextDouble(), 1);
        } 
    }
    return arr;
}

void PrintArray(double[,] arr)
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

Console.Write("Enter number of lines: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());
double[,] newMas = NewArray(m, n, -10, 10); //я не стал делать ввод мин и макс, так как по условию этого нет
PrintArray(newMas);