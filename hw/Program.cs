
﻿Console.Write("Enter a number in roman format: ");
string number = Console.ReadLine();

int ReplaceTo(string text)
{
    int[] numArray = new int[text.Length];

﻿// string[,] table = new string[2, 5];
//table[0, 0]   table[0, 1] ... table[0, 4]
//table[1, 0]   table[1, 1] ... table[1, 4]

//int[,] mas = new int[,]
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
   // {21, 22, 23, 24, 25},
 //   {26, 27, 28, 29, 30},
};

    for (int i = 0; i < text.Length - 1; i++)
    {
        if (text[i] == 'I' || text[i] == 'i')
            if (text[i + 1] != 'i' && text[i + 1] != 'I' && text[i + 1] != 'V' && text[i + 1] != 'v' && text[i + 1] != 'X' && text[i + 1] != 'x') return 0;
        if (text[i] == 'V' || text[i] == 'v')
            if (text[i + 1] != 'i' && text[i + 1] != 'I') return 0;
        if (text[i] == 'X' || text[i] == 'x')
            if (text[i + 1] != 'x' && text[i + 1] != 'X' && text[i + 1] != 'L' && text[i + 1] != 'l' && text[i + 1] != 'I' && text[i + 1] != 'i' && text[i + 1] != 'C' && text[i + 1] != 'c' && text[i + 1] != 'V' && text[i + 1] != 'v') return 0;
        if (text[i] == 'L' || text[i] == 'l')
            if (text[i + 1] != 'i' && text[i + 1] != 'I' && text[i + 1] != 'V' && text[i + 1] != 'v' && text[i + 1] != 'X' && text[i + 1] != 'x') return 0;
        if (text[i] == 'C' || text[i] == 'c')
            if (text[i + 1] != 'i' && text[i + 1] != 'I' && text[i + 1] != 'C' && text[i + 1] != 'c' && text[i + 1] != 'L' && text[i + 1] != 'l' && text[i + 1] != 'X' && text[i + 1] != 'x' && text[i + 1] != 'V' && text[i + 1] != 'v' && text[i + 1] != 'D' && text[i + 1] != 'd' && text[i + 1] != 'M' && text[i + 1] != 'm') return 0;
        if (text[i] == 'D' || text[i] == 'd')
            if (text[i + 1] != 'i' && text[i + 1] != 'I' && text[i + 1] != 'C' && text[i + 1] != 'c' && text[i + 1] != 'L' && text[i + 1] != 'l' && text[i + 1] != 'X' && text[i + 1] != 'x' && text[i + 1] != 'V' && text[i + 1] != 'v') return 0;
        if (text[i] == 'M' || text[i] == 'm')
            if (text[i + 1] != 'i' && text[i + 1] != 'I' && text[i + 1] != 'D' && text[i + 1] != 'd' && text[i + 1] != 'C' && text[i + 1] != 'c' && text[i + 1] != 'L' && text[i + 1] != 'l' && text[i + 1] != 'X' && text[i + 1] != 'x' && text[i + 1] != 'V' && text[i + 1] != 'v' && text[i + 1] != 'M' && text[i + 1] != 'm') return 0;
    }

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == 'I' || text[i] == 'i') numArray[i] = 1;
        if (text[i] == 'V' || text[i] == 'v') numArray[i] = 5;
        if (text[i] == 'X' || text[i] == 'x') numArray[i] = 10;
        if (text[i] == 'L' || text[i] == 'l') numArray[i] = 50;
        if (text[i] == 'C' || text[i] == 'c') numArray[i] = 100;
        if (text[i] == 'D' || text[i] == 'd') numArray[i] = 500;
        if (text[i] == 'M' || text[i] == 'm') numArray[i] = 1000;
    }

    for (int i = 0; i < numArray.Length; i++)
    {
        if (numArray[i] == 0)
        {
            return 0;
        }
    }


    if (numArray.Length > 2)
    {
        for (int i = 1; i < numArray.Length - 1; i++)
        {
            if (numArray[i] == numArray[i - 1] && numArray[i + 1] > numArray[i - 1]) return 0;
            
            if ((numArray[i] == 1 && numArray[i + 1] > numArray[i - 1]) || (numArray[i] == 1 && numArray[i + 1] == 5 && numArray[i - 1] == 5)) return 0;
            if ((numArray[i] == 5 && numArray[i + 1] > numArray[i - 1]) || (numArray[i] == 5 && numArray[i + 1] == 1 && numArray[i - 1] == 1)) return 0;
            if ((numArray[i] == 10 && numArray[i + 1] > numArray[i - 1]) || (numArray[i] == 10 && numArray[i + 1] == 1 && numArray[i - 1] == 1) || (numArray[i] == 10 && numArray[i + 1] == 50 && numArray[i - 1] == 50)) return 0;
            if ((numArray[i] == 50 && numArray[i + 1] > numArray[i - 1]) || (numArray[i] == 50 && numArray[i + 1] == 10 && numArray[i - 1] == 10)) return 0;
            if ((numArray[i] == 100 && numArray[i + 1] > numArray[i - 1]) || (numArray[i] == 100 && numArray[i + 1] == 10 && numArray[i - 1] == 10) || (numArray[i] == 100 && numArray[i + 1] == 500 && numArray[i - 1] == 500)) return 0;
            if ((numArray[i] == 1000 && numArray[i + 1] > numArray[i - 1]) || (numArray[i] == 1000 && numArray[i + 1] == 100 && numArray[i - 1] == 100)) return 0;
            
        }
    }

int[] PrintInLine(int[,] arr)
{
    int count = arr.GetLength(0) * arr.GetLength(1);
    int[] line = new int [count];
    for (int j = 0; count >= 0; j++)
    {
        for (int i = j; i <= arr.GetLength(1) - 1 - j; i++)
        {
            //Console.Write($"{arr[arr.GetLength(0) - 1 - j, i]} ");
            line[arr.GetLength(0) * arr.GetLength(1) - count] = arr[arr.GetLength(0) - 1 - j, i];
            count -= 1;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int i = arr.GetLength(0) - 2 - j; i > j; i--)
        {
            line[arr.GetLength(0) * arr.GetLength(1) - count] = arr[i, arr.GetLength(1) - 1 - j];//Console.Write($"{arr[i, arr.GetLength(1) - 1 - j]} ");
            count -= 1;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int i = arr.GetLength(1) - 1 - j; i >= j; i--)
        {
            //Console.Write($"{arr[0 + j, i]} ");
            line[arr.GetLength(0) * arr.GetLength(1) - count] = arr[0 + j, i];
            count -= 1;
            if (count == 0) break;
        }
        if (count == 0) break;
        for (int i = j + 1; i < arr.GetLength(0) - 1 - j; i++)
        {
            //Console.Write($"{arr[i, 0 + j]} ");
            line[arr.GetLength(0) * arr.GetLength(1) - count] = arr[i, 0 + j];
            count -= 1;
            if (count == 0) break;
        }        
    }
    //Console.Write($"count = '{count}' ");
    return line;
}



    int result = numArray[numArray.Length - 1];
    int count = 1;

    for (int i = numArray.Length - 1; i > 0; i--)
    {
        if (numArray[i - 1] == numArray[i])
        {
            if (count == 3)
            {
                return 0;
            }
            else
            {
                result += numArray[i - 1];
                count++;
            }
        }
        else
        {
            count = 1;
            if (numArray[i - 1] > numArray[i])
            {
                result += numArray[i - 1];
            }
            else result -= numArray[i - 1];
        }
    }
    return result;
}

if (ReplaceTo(number) == 0 || ReplaceTo(number) > 3999) Console.WriteLine("There is a mistake in the roman number!");
else Console.WriteLine(ReplaceTo(number));



//PrintInLine(mas);
Console.Write(String.Join(" ", PrintInLine(mas)));

