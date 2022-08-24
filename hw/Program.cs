int[] Mas(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int[] NewMas(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if(arr[j] < arr[j + 1]) 
            {
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }
    return arr;
}

Console.Write("Enter the number of array elements: ");
int num = int.Parse(Console.ReadLine());
if (num <= 0) goto Close2;
Console.Write("Enter the min value for array elements: ");
int Amin = int.Parse(Console.ReadLine());
Console.Write("Enter the max value for array elements: ");
int Amax = int.Parse(Console.ReadLine());
if (Amin > Amax) goto Close1;

int[] mas = Mas(num, Amin, Amax);
Console.WriteLine($"The array: [{String.Join(" ", mas)}]");
int[] mas1 = NewMas(mas);

Console.WriteLine($"After sorting: [{String.Join(" ", mas1)}]");

Close1:
if (Amin > Amax) Console.WriteLine("Unable to create an array!");

Close2:
if (num <= 0) Console.WriteLine("Unable to create an array! Max must be greater then Min.");

