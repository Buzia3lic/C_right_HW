int SumMtoN(int start, int num)
{
    if (start == num) return start;
    return start + SumMtoN(start + 1, num);
}

Console.Write("Enter N1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter N2: ");
int num2 = int.Parse(Console.ReadLine());

int sum = SumMtoN(num1, num2);
Console.Write($"Sum of all numbers from {num1} to {num2} is: {sum}");