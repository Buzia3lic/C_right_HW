Console.Write("Enter a number in roman format: ");
string number = Console.ReadLine();

int ReplaceTo(string text)
{
    int[] numArray = new int[text.Length];

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


