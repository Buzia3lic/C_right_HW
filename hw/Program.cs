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

void FindElement(int[,] arr, int fm, int fn)
{
    if (fm >= 0 && fm < arr.GetLength(0) && fn >= 0 && fn < arr.GetLength(1))
        Console.WriteLine($"The search element of array [{fm}, {fn}] is: |{arr[fm, fn]}|");
    else
        Console.WriteLine($"The element [{fm}, {fn}] does not exist in the array! ");
}

Console.Write("Enter number of lines: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());
int[,] newMas = NewArray(m, n, 0, 9); //я не стал делать ввод мин и макс, так как по условию этого нет
Console.WriteLine("The array: ");
PrintArray(newMas);
Console.Write("Enter line number for searching: ");
int findM = int.Parse(Console.ReadLine());
Console.Write("Enter column number for searching: ");
int findN = int.Parse(Console.ReadLine());
FindElement(newMas, findM, findN);
