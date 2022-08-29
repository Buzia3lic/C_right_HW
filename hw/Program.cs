// string[,] table = new string[2, 5];
//table[0, 0]   table[0, 1] ... table[0, 4]
//table[1, 0]   table[1, 1] ... table[1, 4]

// int[,] mas = new int[,]
// {
//     {1,  2,  3,  4},
//     {5,  6,  7,  8},
//     {9,  10, 11, 12},
//     {13, 14, 15, 16},
// };

int[,] mas = new int[,]
{
    {1,  2,  3,  4,  5},
    {6,  7,  8,  9,  10},
    {11, 12, 13, 14, 15},
    {16, 17, 18, 19, 20},
    {21, 22, 23, 24, 25},
    {26, 27, 28, 29, 30},
};


void Print(int[,] arr)
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

void PrintInLine(int[,] arr)
{
    int count = arr.GetLength(0) * arr.GetLength(1);
    for (int j = 0; count >= 0; j++)
    {
        for (int i = j; i <= arr.GetLength(1) - 1 - j; i++)
        {
            Console.Write($"{arr[arr.GetLength(0) - 1 - j, i]} ");
            count -= 1;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int i = arr.GetLength(0) - 2 - j; i > j; i--)
        {
            Console.Write($"{arr[i, arr.GetLength(1) - 1 - j]} ");
            count -= 1;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int i = arr.GetLength(1) - 1 - j; i >= j; i--)
        {
            Console.Write($"{arr[0 + j, i]} ");
            count -= 1;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int i = j + 1; i < arr.GetLength(0) - 1 - j; i++)
        {
            Console.Write($"{arr[i, 0 + j]} ");
            count -= 1;
            if (count == 0) break;
        }        
    }
    //Console.Write($"count = '{count}' ");
}

Print(mas);
Console.WriteLine();

PrintInLine(mas);