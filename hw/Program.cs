double AckerFun(double m, double n)
{
    if (m == 0) return n + 1;
    if (m == 1) return n + 2;
    if (m == 2) return 2 * n + 3;
    if (m == 3) return Math.Pow (2, n + 3) - 3;
    return Math.Pow (2, (AckerFun(m - 1, n)) + 3) - 3;
}

Console.Write("Enter m: ");
double m = int.Parse(Console.ReadLine());
Console.Write("Enter n: ");
double n = int.Parse(Console.ReadLine());
if (m < 0 || n < 0) Console.Write("Tne numbers mut be greater then 0!");
else Console.Write(AckerFun(m, n));


