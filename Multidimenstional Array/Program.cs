double[,] a = new double[2, 5];
Console.WriteLine("Enter the array Elements:");
for(int i = 0; i < 2; i++)
    for (int j = 0; j < 5; j++)
        a[i, j] = double.Parse(Console.ReadLine());

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{a[i,j]} ");
    }
    Console.WriteLine();
}
int l1 = a.Length;
int l2 = a.GetLength(0);
int l3 = a.GetLength(1);

Console.WriteLine($"Array Lenght:{l1}");
Console.WriteLine($"Row Lenght:{l2}");
Console.WriteLine($"Column Lenght:{l3}");

