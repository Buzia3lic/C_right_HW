double FindX(double k1, double k2, double b1, double b2)
{
    return (b1 - b2) / (k2 - k1);
}

double FindY(double k1, double k2, double b1, double b2)
{
    return k2 * (b1 - b2) / (k2 - k1) + b2;
}

void Result(double k1, double k2, double b1, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("These lines match!");
    }
    else
    {
        if (k1 == k2)
        {
            Console.WriteLine("These lines are parallel!");
        }
        else
        {
            Console.WriteLine($"Intersection point is: ({Math.Round(FindX(k1, k2, b1, b2), 2)}; {Math.Round(FindY(k1, k2, b1, b2), 2)})");
        }
    }
}

Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2.");
Console.Write("Enter k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = double.Parse(Console.ReadLine());

Result(k1, k2, b1, b2);