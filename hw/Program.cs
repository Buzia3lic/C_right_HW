int Sqrt(int num)
{
    double[] arr = new double[2];
    arr[0] = num / 2;
    double diff = 0.000001;
    while((arr[0] - arr[1]) > diff)
    {
        arr[0] = (arr[0] + num / arr[0]) / 2;
        arr[1] = (arr[0] + num / arr[0]) / 2;
    }
    int result = (int)arr[1];
    return result;

}

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int result = Sqrt(num);
Console.WriteLine($"The square root of a number {num} is: {result}");

