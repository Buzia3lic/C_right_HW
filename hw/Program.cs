int[,,] GetArrey(int x, int y, int z)
{
    int[] temp = new int [x * y * z];
    temp[0] = new Random().Next(10, 92);
    for (int i = 1; i < temp.Length; i++)
    {
        temp[i] =  temp[i - 1] + 1;   
    }
    Console.WriteLine(String.Join(" ", temp));
    
    int[,,] result = new int[x, y, z];
    int timer = 0;
    int end = temp.Length;
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
               
                timer = new Random().Next(0, end);
                result[i, j, k] = temp[timer];
                temp[timer] = temp[end - 1];
                end--;
            }
        }
    }

    

    return result;
}

void PrintArr(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] theArray = GetArrey(2, 2, 2);
PrintArr(theArray);