int[] Mas(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int amount(int[] arr)
{
    int a = 0;
    foreach (int el in arr)
    {
        a += (el % 2) == 0 ? 1 : 0;
    }
    return a;
}

Console.Write("Enter the number of array elements: ");
int num = int.Parse(Console.ReadLine());
if (num <= 0) goto Close;

int[] mas = Mas(num, 100, 1000);
Console.WriteLine($"The array: [{String.Join(" ", mas)}]");
Console.WriteLine($"The number of even numbers in the array is: {amount(mas)}");

Close:
if (num <= 0) Console.WriteLine("Unable to create an array. The number must be greater than 0!");
