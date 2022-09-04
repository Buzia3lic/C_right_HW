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
    Console.WriteLine();
}

int[,] ResultMatrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return result;
}

Console.Write("Enter M1 for first matrix: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Enter N1 for first matrix: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Enter M2 for second matrix: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Enter N2 for second matrix: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine();

if (n1 != m2) Console.WriteLine("It's impossible to multiply these matrices!");
else
{
    int[,] theArray1 = GetArrey(m1, n1);
    int[,] theArray2 = GetArrey(m2, n2);
    Console.WriteLine("The first matrix:");
    PrintArr(theArray1);
    Console.WriteLine("The second matrix:");
    PrintArr(theArray2);
    int[,] result = ResultMatrix(theArray1, theArray2);
    Console.WriteLine("The result matrix:");
    PrintArr(result);
}
