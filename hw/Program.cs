int CountNum(int n)
{   
    int count = 0;
    int temp = 0;
    Console.WriteLine("Enter numbers: ");
    for (int i = 0; i < n; i++)
    {
        temp = int.Parse(Console.ReadLine());
        if (temp > 0)
        {
            Console.CursorTop--;
            Console.WriteLine($"{temp} - greater than 0!");
            count += 1;
        }
    }
    return count;
}

Console.Write("Enter the number of elements: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"Number of numbers greater than 0 is: {CountNum(num)}");