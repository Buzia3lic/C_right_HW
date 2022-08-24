double[] Mas(int size, int min, int max)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round((new Random().Next(min, max) + new Random().NextDouble()), 2);
    }
    return arr;
}

double Min(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double Max(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

Console.Write("Enter the number of array elements: ");
int num = int.Parse(Console.ReadLine());
if (num <= 0) goto Close;

double[] mas = Mas(num, 0, 100);
Console.WriteLine($"The array: [{String.Join("|", mas)}]");
Console.WriteLine($"The min is: {Min(mas)}");
Console.WriteLine($"The max is: {Max(mas)}");
Console.WriteLine($"The diff is: {Max(mas) - Min(mas)}");

Close:
if (num <= 0) Console.WriteLine("Unable to create an array. The number must be greater than 0!");
